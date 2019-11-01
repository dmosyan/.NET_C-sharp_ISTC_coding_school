using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware
{
    public class CustomMiddleWare
    {
        // Delegate which will include the link for the next component of request
        private readonly RequestDelegate next;

        //Constructor
        public CustomMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }

        //The name of the method should be Invoke or InvokeAsync
        public async Task InvokeAsync(HttpContext context)
        {
            //geting the type of the request
            string method = context.Request.Method;
            if (method == "GET")
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("That is GET request");
            }
            else
                await next.Invoke(context);
        }
    }
}
