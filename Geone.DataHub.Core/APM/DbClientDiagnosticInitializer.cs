using Elastic.Apm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Geone.DataHub.Core.APM
{
    internal sealed class DbClientDiagnosticInitializer : IObserver<DiagnosticListener>, IDisposable
    {
        private readonly IApmAgent _apmAgent;

        private IDisposable _sourceSubscription;

        internal DbClientDiagnosticInitializer(IApmAgent apmAgent) => _apmAgent = apmAgent;

        public void Dispose() => _sourceSubscription?.Dispose();

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(DiagnosticListener value)
        {
            if (value.Name == DbClientDiagnostic.DB_DIAGNOSTIC_LISTENER)
                _sourceSubscription = value.Subscribe(new DbClientDiagnosticListener(_apmAgent));
        }
    }
}
