using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;
using CleanArchitecture.Application;
using CleanArchitecture.Infrustructure;
using CleanArchitecture.DataTransfer.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
               .ReadFrom.Configuration(builder.Configuration)
               .WriteTo.Console(new CompactJsonFormatter())
               .CreateLogger();

Log.Logger.Information("Logger is open successfully");

builder.Host.UseSerilog();
builder.Services.AddApplicationDependency();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork<DbContext>>();
builder.Services.AddInfrustructureDependency(builder.Configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error/Error");
    app.UseStatusCodePagesWithReExecute("/Error/PageNotFound/{0}");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
