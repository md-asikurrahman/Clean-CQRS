using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;
using WebAPI.Extensions;
using WebAPI.Options;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices(typeof(Program));
var app = builder.Build();

app.AddServicesPipeline(typeof(Program));

app.Run();
