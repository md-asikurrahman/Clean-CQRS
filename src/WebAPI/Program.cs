using WebAPI.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.AddServices(typeof(Program));
var app = builder.Build();

app.AddServicesPipeline(typeof(Program));

app.Run();
