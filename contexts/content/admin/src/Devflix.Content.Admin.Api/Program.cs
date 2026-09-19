using Devflix.Content.Admin.Api.Configurations;
using Devflix.Content.Admin.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddInfrastructureConfiguration(builder.Configuration)
    .AddBackgroundServiceConfiguration()
    .AddApplicationConfiguration()
    .AddSecurity(builder.Configuration)
    .AddAndConfigureControllers();

var app = builder.Build();

app.UseDocumentation();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

await app.RunAsync();

public partial class Program
{
}