using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.Listen(IPAddress.Loopback, 5000); 
    // });
});

var app = builder.Build();
app.UseHttpsRedirection(); 
