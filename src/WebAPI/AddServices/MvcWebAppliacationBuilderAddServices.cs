﻿using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Options;

namespace WebAPI.AddServices
{
    public class MvcWebAppliacationBuilderAddServices : IWebAppliacationBuilderAddServices
    {
        public void AddServices(WebApplicationBuilder builder)
        {
            
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new UrlSegmentApiVersionReader();
            });
            builder.Services.AddVersionedApiExplorer(config =>
            {
                config.GroupNameFormat = "'v'VVV";
                config.SubstituteApiVersionInUrl = true;
            });
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
