using System.Reflection;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var response =
app.MapGet("/", () => $"Version {Assembly.GetExecutingAssembly().GetName().Version} FullVersion: {Assembly.GetExecutingAssembly()?
  .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
  .InformationalVersion} ");
app.Run();
