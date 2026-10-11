var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Register swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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