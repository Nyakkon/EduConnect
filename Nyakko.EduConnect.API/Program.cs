
using System.ComponentModel.Design;
using Microsoft.OpenApi.Models;
using Nyakko.EduConnect.API;
using Serilog;
var builder = WebApplication.CreateBuilder(args);


builder.Host.UseSerilog((Context, configuration) => 
    configuration.ReadFrom.Configuration(Context.Configuration));
// Add services to the container.
;
builder.Services.AddScoped<IHelloService, HelloService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Nyakko API",
        Version = "v1",
        Description = "API for EduConnect",
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();