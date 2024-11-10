using Microsoft.EntityFrameworkCore;
using WarehouseServer.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



//// הוספתי את שירות ה-DbContext כדי להתחבר למסד הנתונים
builder.Services.AddDbContext<WarehouseDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WarehouseConnectionString"))); // קישור ל-ConnectionString ב-appsettings.json

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
