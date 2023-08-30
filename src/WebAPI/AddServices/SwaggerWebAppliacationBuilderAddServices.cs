using WebAPI.Options;

namespace WebAPI.AddServices
{
    public class SwaggerWebAppliacationBuilderAddServices : IWebAppliacationBuilderAddServices
    {
        public void AddServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
