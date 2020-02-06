using BlazorStrap;
using BlazorWasmRegexTest.Shared.Interfaces;
using BlazorWasmRegexTest.Shared.Services;
using Cloudcrate.AspNetCore.Blazor.Browser.Storage;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWasmRegexTest.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBootstrapCSS();
            services.AddStorage();

            services.AddTransient<IRegexService, RegexService>();
            services.AddTransient<IHtmlHelperService, HtmlHelperService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
