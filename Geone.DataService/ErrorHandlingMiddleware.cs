using Geone.DataService.Core.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Geone.DataService
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerFactory _loggerFactory;

        public ErrorHandlingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _loggerFactory = loggerFactory;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch ( Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (!context.Response.HasStarted)
            {
                if (exception is DataServiceException)
                {
                    return ResponseErrorMessage(context, exception, true);
                }
                else
                {
                    return ResponseErrorMessage(context, exception, false);
                }
            }
            else
            {
                return Task.CompletedTask;
            }
        }

        void LogWarning(ILogger logger, Exception exception)
        {
            logger.LogWarning(exception, exception.Message);
        }

        void LogError(ILogger logger, Exception exception)
        {
            logger.LogError(exception, exception.Message);
        }

        static Task Response401(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/text";
            context.Response.StatusCode = 401;
            return context.Response.WriteAsync(exception.Message);
        }

        static Task ResponseErrorMessage(HttpContext context, Exception exception, bool onlyMessage)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;

            dynamic result;
            if (!onlyMessage)
            {
                result = new
                {
                    error = exception.Message,
                    stackTrace = exception.StackTrace
                };
            }
            else
            {
                result = new
                {
                    error = exception.Message,
                };
            }

            string json = JsonConvert.SerializeObject(result);
            return context.Response.WriteAsync(json);
        }
    }
}
