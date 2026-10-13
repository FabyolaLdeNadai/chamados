using System.Runtime.InteropServices;
using Chamados.Domain;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Chamados.Web em execução");
app.MapGet("/status", () => Enum.GetNames<StatusChamado>());

if (app.Environment.IsDevelopment())
{
    app.MapGet("/ambiente", (IWebHostEnvironment env) => new
    {
        env.EnvironmentName,
        Runtime = RuntimeInformation.FrameworkDescription
    });
}

app.Run();