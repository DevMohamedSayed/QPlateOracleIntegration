using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QPLate_Water.OracleIntegrationAPI.BL.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.Configurations
{
    public class GlobalExceptionHandlingMiddleware 
    {
        private readonly RequestDelegate _next;
        public GlobalExceptionHandlingMiddleware(RequestDelegate next) => _next = next;
        
        public async Task Invoke (HttpContext context)
        {
            try
            {

            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            HttpStatusCode status;
            var stackTrace = string.Empty;
            string message = "";
            var exceptionType = ex.GetType();


            if (exceptionType == typeof(NotFoundException))
            {
                message = ex.Message;
                status = HttpStatusCode.BadRequest;
                stackTrace = ex.StackTrace;
            } else if (exceptionType == typeof(Exception))
            {
                message = ex.Message;
                status = HttpStatusCode.NotFound;
                stackTrace = ex.StackTrace;
            } else if (exceptionType == typeof(UnAuthenticatedException))
            {
                message = ex.Message;
                status = HttpStatusCode.NetworkAuthenticationRequired;
                stackTrace = ex.StackTrace;
            }
            else if (exceptionType == typeof(UnAuthorizedException))
            {
                message = ex.Message;
                status = HttpStatusCode.Unauthorized;
                stackTrace = ex.StackTrace;
            }
            else
            {
                message = ex.Message;
                status = HttpStatusCode.InternalServerError;
                stackTrace = ex.StackTrace;
            }
            var exceptionResult = JsonSerializer.Serialize(new { error = message, stackTrace });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)status;
            return context.Response.WriteAsync(exceptionResult);
       }
    }
}
