using Twitter.Api;
using Twitter.Api.Configuration;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

builder.Host.UseSerilog((host, cfg) =>
{
    cfg.ReadFrom.Configuration(host.Configuration);
});
services.AddAppServices();

services.AddControllers();

services.AddEndpointsApiExplorer();

services.AddAppSwagger();

var app = builder.Build();

app.UseAppSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();