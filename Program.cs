




using bai2api.DataContext;
using bai2api.Payload.Converter;
using bai2api.Payload.DTO;
using bai2api.Payload.Response;
using bai2api.Service.Implement;
using bai2api.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<bai2api.DataContext.AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));






// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IService_DuAn, Service_DuAn>();
builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<Converter_DuAn>();
builder.Services.AddScoped<ResponseBase>();
builder.Services.AddScoped<ResponseObject<DTO_DuAn>>();


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
