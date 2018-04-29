using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using DotNetAPIControllers.Models;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace DotNetAPIControllers
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepository, MemoryRepository>();
            services.AddMvc()
                    .AddXmlDataContractSerializerFormatters()
                    .AddMvcOptions(opts => {
                        opts.FormatterMappings.SetMediaTypeMappingForFormat("xml",
                            new MediaTypeHeaderValue("application/xml"));
                        opts.RespectBrowserAcceptHeader = true;
                        opts.ReturnHttpNotAcceptable = true;
                    });;
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
