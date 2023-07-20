using Lab2.Extensions;
using Lab2.Middlewares;
using Microsoft.AspNetCore.HttpLogging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var errorLogger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();   
builder.Logging.AddSerilog(errorLogger);
builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.RequestMethod | HttpLoggingFields.RequestPath;
});

builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureRepositories();
builder.Services.ConfigureServices();
builder.Services.ConfigureIdentity();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseHttpLogging();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<CustomExceptionHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
