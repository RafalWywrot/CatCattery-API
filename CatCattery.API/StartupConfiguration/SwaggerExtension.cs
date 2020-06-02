using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace CatCattery.API.StartupConfiguration {
    public static class SwaggerExtension {
        public static IServiceCollection AddSwagger(this IServiceCollection services) {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", new OpenApiInfo {Title = "Cat Cattery API", Version = "v1"});
            });

            return services;
        }
    }
}