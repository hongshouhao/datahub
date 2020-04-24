using Elastic.Apm;
using Elastic.Apm.Api;
using Elastic.Apm.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using static Geone.DataHub.Core.APM.DbClientDiagnostic;

namespace Geone.DataHub.Core.APM
{
    public class DbClientDiagnosticListener : IObserver<KeyValuePair<string, object>>
    {
        private readonly IApmAgent _apmAgent;
        private readonly IApmLogger _logger;

        private readonly ConcurrentDictionary<Guid, ISpan> _processingQueries = new ConcurrentDictionary<Guid, ISpan>();

        public DbClientDiagnosticListener(IApmAgent apmAgent)
        {
            _apmAgent = apmAgent;
            _logger = _apmAgent.Logger;
        }

        public void OnNext(KeyValuePair<string, object> value)
        {
            switch (value.Key)
            {
                case BEFORE_CONNECTING
                    when value.Value is BeforeConnecttingEventArgs payload && _apmAgent.Tracer.CurrentTransaction != null:
                    HandleBeforeConnecttingEvent(payload);
                    return;
                case AFTER_CONNECTING
                    when value.Value is DbEventArgs payload && _apmAgent.Tracer.CurrentTransaction != null:
                    HandleAfterConnecttingEvent(payload);
                    return;
                case BEFORE_COMMAND_EXECUTE
                    when value.Value is BeforeExecutingEventArgs payload && _apmAgent.Tracer.CurrentTransaction != null:
                    HandleCommandStartEvent(payload);
                    return;
                case AFTER_COMMAND_EXECUTE
                    when value.Value is DbEventArgs payload:
                    HandleCommandSucceededEvent(payload);
                    return;
                case ERROR_COMMAND_EXECUTE
                    when value.Value is ErrorEventArgs payload:
                    HandleCommandFailedEvent(payload);
                    return;
                case BEFORE_READ_JSON
                    when value.Value is DbEventArgs payload:
                    HandleReadResultStartEvent(payload);
                    return;
                case AFTER_READ_JSON
                    when value.Value is AfterReadingResultEventArgs payload:
                    HandleReadResultEndEvent(payload);
                    return;
            }
        }

        private void HandleBeforeConnecttingEvent(BeforeConnecttingEventArgs @event)
        {
            try
            {
                var executionSegment = _apmAgent.Tracer.CurrentSpan ?? (IExecutionSegment)_apmAgent.Tracer.CurrentTransaction;
                string addr = $"Address={@event.Address}";
                if (@event.Port.HasValue)
                {
                    addr = addr + $";Port={@event.Port}";
                }

                var span = executionSegment.StartSpan($"Connect Databasse ({addr})", ApiConstants.TypeDb, @event.DbType.ToString().ToLower());
                if (!_processingQueries.TryAdd(@event.Id, span)) return;

                span.Context.Destination = new Destination
                {
                    Address = @event.Address,
                    Port = @event.Port
                };
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'before openning connection event''", ex, null);
            }
        }

        private void HandleAfterConnecttingEvent(DbEventArgs @event)
        {
            try
            {
                if (!_processingQueries.TryRemove(@event.Id, out var span)) return;
                span.End();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'after openning connection event''", ex, null);
            }
        }

        private void HandleCommandStartEvent(BeforeExecutingEventArgs @event)
        {
            try
            {
                var executionSegment = _apmAgent.Tracer.CurrentSpan ?? (IExecutionSegment)_apmAgent.Tracer.CurrentTransaction;
                var spanName = @event.CommandText.Replace(Environment.NewLine, " ");
                var span = executionSegment.StartSpan(spanName, ApiConstants.TypeDb, @event.DbType.ToString().ToLower());

                if (!_processingQueries.TryAdd(@event.Id, span)) return;

                span.Action = ApiConstants.ActionQuery;

                span.Context.Db = new Database
                {
                    Statement = spanName,
                    Instance = @event.Database,
                    Type = @event.DbType.ToString().ToLower()
                };

                span.Context.Destination = new Destination
                {
                    Address = @event.Address,
                    Port = @event.Port
                };
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'command started event''", ex, null);
            }
        }

        private void HandleCommandSucceededEvent(DbEventArgs @event)
        {
            try
            {
                if (!_processingQueries.TryRemove(@event.Id, out var span)) return;
                span.End();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'command succeeded event''", ex, null);
            }
        }

        private void HandleCommandFailedEvent(ErrorEventArgs @event)
        {
            try
            {
                if (!_processingQueries.TryRemove(@event.Id, out var span)) return;
                span.CaptureException(@event.Exception);
                span.End();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'command failed event''", ex, null);
            }
        }

        private void HandleReadResultStartEvent(DbEventArgs @event)
        {
            try
            {
                var executionSegment = _apmAgent.Tracer.CurrentSpan ?? (IExecutionSegment)_apmAgent.Tracer.CurrentTransaction;
                var span = executionSegment.StartSpan("Read Data", ApiConstants.TypeExternal);

                if (!_processingQueries.TryAdd(@event.Id, span)) return;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'read data event''", ex, null);
            }
        }

        private void HandleReadResultEndEvent(AfterReadingResultEventArgs @event)
        {
            try
            {
                if (!_processingQueries.TryRemove(@event.Id, out var span)) return;
                span.End();
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, "Exception was thrown while handling 'read data end event''", ex, null);
            }
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }
    }
}
