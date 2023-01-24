using System.Diagnostics;

namespace Fifa22.WebService
{
    public static class AppMiddlewareExtensions
    {
        public static IApplicationBuilder RegisterMyFirstMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                //if (context.Request.Path.Value.ToUpper().Contains("player".ToUpper()))
                //{
                //    await context.Response.WriteAsync("You are not authorized to view player data.");
                //    return;
                //}

                Debug.WriteLine("hello from my first middleware");
                await next();
            });
            return app;
        }
    }
}
