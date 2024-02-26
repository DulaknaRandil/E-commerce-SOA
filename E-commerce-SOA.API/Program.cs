using E_commerce_SOA.API.DBContext;
using E_commerce_SOA.BussinessLayer.DBContext;
using E_commerce_SOA.BussinessLayer.Repositories;
using E_commerce_SOA.BussinessLayer.Reposotories;
using E_commerce_SOA.BussinessLayer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<E_CommerceContext>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));
builder.Services.AddDbContext<UserRegisterContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));
builder.Services.AddDbContext<ProductContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));


builder.Services.AddDbContext<CategoryContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));
builder.Services.AddDbContext<ShoppingCartContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));
builder.Services.AddDbContext<CartItemContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));
builder.Services.AddDbContext<OrderItemContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));
builder.Services.AddDbContext<OrderContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDB")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<UserRegisterService, UserRegistrationRepository>();
builder.Services.AddScoped<GetUserRegisterService,GetUserRegisterRepository>();
builder.Services.AddScoped<ProductService,ProductRepository>();
builder.Services.AddScoped<CategoryService,CategoryRepository>();
builder.Services.AddScoped<ShoppingCartService, ShoppingCartRepository>();
builder.Services.AddScoped<CartItemService,CartItemRepository>();
builder.Services.AddScoped<OrderItemService,OrderItemRepository>();
builder.Services.AddScoped<OrderService,OrderRepository>();
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
