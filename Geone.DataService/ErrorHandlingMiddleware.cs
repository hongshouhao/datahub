using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Linq;
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
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// TODO:如果有需要还可以细分
        /// </summary>
        /// <param name="context"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            if (!context.Response.HasStarted)
            {
                return ResponseErrorMessage(context, exception);
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

        static Task ResponseErrorMessage(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;

            string result = JsonConvert.SerializeObject(new
            {
                error = exception.Message,
                stackTrace = exception.StackTrace
            });

            return context.Response.WriteAsync(result);
        }
    }
}
