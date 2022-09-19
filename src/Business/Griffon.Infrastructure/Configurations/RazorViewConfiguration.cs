using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Griffon.Infrastructure.Configurations
{
    public static class RazorViewConfiguration
    {
        public static void ConfigureViewEngine(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(o =>
            {
                o.ViewLocationFormats.Clear();
                o.ViewLocationFormats.Add("/Views/Admin/{1}/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("/Views/Admin/Shared/{0}" + RazorViewEngine.ViewExtension);
                
                o.ViewLocationFormats.Add("/Views/Client/{1}/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("/Views/Client/Shared/{0}" + RazorViewEngine.ViewExtension);
            });
        }
    }
}
