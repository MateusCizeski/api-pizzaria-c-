using pizzaria_api.Model.Category;
using pizzaria_api.Model.Items;
using pizzaria_api.Model.Orders;
using pizzaria_api.Model.Products;
using pizzaria_api.Model.Users;
using pizzaria_api.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IRepCategory, RepCategory>();
builder.Services.AddTransient<IRepItems, RepItem>();
builder.Services.AddTransient<IRepOrder, RepOrder>();
builder.Services.AddTransient<IRepProduct, RepProduct>();
builder.Services.AddTransient<IRepUser, RepUser>();

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
