using ContactAPI.DATA;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(option => { option.AddDefaultPolicy(builder => { builder.WithOrigins("https://localhost:7238","http://localhost:5240").AllowAnyHeader
    ().AllowAnyMethod();});});
//builder.Services.AddDbContext<DBContext>(option => option.UseInMemoryDatabase("ContactsDb"));
builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultDatabase")));
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
