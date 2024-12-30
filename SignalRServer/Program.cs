using SignalRServer.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(options =>
{
    // Lắng nghe trên tất cả các địa chỉ IP và cổng 7183
    options.Listen(System.Net.IPAddress.Any, 7183, listenOptions =>
    {
        // Sử dụng HTTPS với chứng chỉ tự ký
        listenOptions.UseHttps(@"C:\Users\nchin\Downloads\Cert.pfx", "yourpassword");
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddSignalR(options =>
{
    options.MaximumReceiveMessageSize = 1024 * 1024;
});

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<DreawHub>("api/hub");

app.MapReverseProxy();

app.Run();
