using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ch1seL.WebApplication.Utils
{
    public static class JsRuntimeExtensions
    {
        public static async ValueTask<T> CatchJsExceptionAsync<T>(this ValueTask<T> taskFactory, Action<JSException> exceptionFactory)
        {
            try
            {
                return await taskFactory;
            }
            catch (JSException e)
            {
                exceptionFactory(e);
                throw;
            }
        }
        
        public static async Task<T> CatchJsExceptionAsync<T>(this Task<T> taskFactory, Action<JSException> exceptionFactory)
        {
            try
            {
                return await taskFactory;
            }
            catch (JSException e)
            {
                exceptionFactory(e);
                throw;
            }
        }
    }
}