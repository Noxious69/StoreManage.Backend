using Inventory.Core.Entities;
using Inventory.Infrastructore.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<InventoryDB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapPost("/newOrder", async (InventoryDB db, Order order) => new
{
    order.CustomerName,
    order.CustomerAddress,
    order.CustomerPhone,
    order.OrderType,
    order.OrderColor,
    order.OrderCount,
    order.BoxCount,
    order.BoxType,
    order.Lable,
    order.Edge,
    order.TwoColor,
   

}) ; 
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
