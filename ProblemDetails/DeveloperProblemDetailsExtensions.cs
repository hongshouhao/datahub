using Microsoft.AspNetCore.Http;
using System;
using MvcProblemDetails = Microsoft.AspNetCore.Mvc.ProblemDetails;

namespace Hellang.Middleware.ProblemDetails
{
    internal static class DeveloperProblemDetailsExtensions
    {
        public static MvcProblemDetails WithExceptionDetails(this MvcProblemDetails problem, Exception error)
        {
            problem.Extensions["stackTrace"] = error.StackTrace;
            problem.Instance ??= GetHelpLink(error);
            return problem;
        }

        private static string GetHelpLink(Exception exception)
        {
            var link = exception.HelpLink;

            if (string.IsNullOrEmpty(link))
            {
                return null;
            }

            if (Uri.TryCreate(link, UriKind.Absolute, out var result))
            {
                return result.ToString();
            }

            return null;
        }
    }
}
