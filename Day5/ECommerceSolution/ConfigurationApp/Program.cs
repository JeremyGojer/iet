using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
 
builder.Configuration.AddJsonFile("sharedSsettings.json", optional: true);
builder.Configuration.AddJsonFile("appsettings.json", optional: true,reloadOnChange: true);
builder.Configuration.AddEnvironmentVariables();
 
var app = builder.Build();
 
app.MapGet("/", () => app.Configuration.AsEnumerable());
 
app.Run();



app.MapGet("/", (IConfiguration config) => config.AsEnumerable());

app.MapGet("/display-settings", (IConfiguration config) => 
{ 
    string title = config["AppDisplaySettings:AppTitle"];
    bool showCopyright = bool.Parse(
            config["AppDisplaySettings:ShowCopyright"]);
 
    return new { title, showCopyright };
});



var zoomLevel = builder.Configuration["MapSettings:DefaultZoomLevel"];
var lat1 = builder.Configuration["MapSettings:DefaultLocation:Latitude"];
var lat11 = builder.Configuration.GetSection("MapSettings")["DefaultLocation:Latitude"];

app.Run();
