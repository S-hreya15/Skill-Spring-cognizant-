using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi_Handson.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = context.Exception.Message;

            File.WriteAllText("ExceptionLog.txt", message);

            context.Result = new ObjectResult(message)
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}