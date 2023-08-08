using Lab2.Application.Extensions;
using Lab2.Extensions;
using Lab2.Infrastructure.Extensions;
using Lab2.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Logging.ConfigureSerilog(builder.Configuration);

builder.Services.ConfigureLogging();

// For IOptions<T> 
builder.Services.ConfigureConfigurations(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureRepositories();
builder.Services.ConfigureInfrastructureServices();
builder.Services.ConfigureServices();
builder.Services.ConfigureIdentity();

builder.Services.ConfigureAuthentication(builder.Configuration);
builder.Services.ConfigureAuthorization();

builder.Services.ConfigureAutoMapper();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Apply migrations
//await builder.Services.ApplyMigrateAsync();

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpLogging();
app.UseCustomExceptionHandler(builder.Environment);

app.UseHttpsRedirection();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
