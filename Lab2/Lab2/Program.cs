using Lab2.Extensions;
using Lab2.Logging;
using Lab2.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Logging.ConfigureSerilog(builder.Configuration);

builder.Services.ConfigureLogging();

// For IOptions<T> 
builder.Services.ConfigureConfigurations(builder.Configuration);

builder.Services.AddControllers();
builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureRepositories();
builder.Services.ConfigureServices();
builder.Services.ConfigureIdentity();

builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.ConfigureAuthorization();

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

app.UseCustomExceptionHandler(builder.Environment, app.Services.GetRequiredService<IExceptionLogger>());

// app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
