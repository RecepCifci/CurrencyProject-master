using System.Web.Http;
using WebActivatorEx;
using CurrencyProject.WebAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace CurrencyProject.WebAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {

                        c.SingleApiVersion("v1", "CurrencyProject.WebAPI");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\CurrencyProjectWebAPI.XML", System.AppDomain.CurrentDomain.BaseDirectory));
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}