using Microsoft.EntityFrameworkCore;
using paystream.src.Data;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Register swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Read the connection string from the appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register DbContext with PostgreSQL configuration
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Map controller Endpoints
app.MapControllers();
app.UseHttpsRedirection();

app.Run();