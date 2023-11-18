using Inventory.Backend.DTOs;
using Inventory.Core.Entities;
using Inventory.Infrastructore.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSwaggerGen();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<InventoryDB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});

builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
               builder.
               AllowAnyHeader().
               AllowAnyOrigin().
               AllowAnyMethod()));

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/neworder", (InventoryDB db, Order order) =>
{
    db.Order.Add(order);
    db.SaveChanges();
    return Results.Ok();

    // order.CustomerName,
    // order.CustomerAddress,
    // order.CustomerPhone,
    // order.OrderType,
    // order.OrderColor,
    // order.OrderCount,
    // order.BoxCount,
    // order.BoxType,
    // order.Lable,
    // order.Edge,
    // order.TwoColor,

}) ;

app.MapPost("/list", (InventoryDB db, OrderResultDto result) =>
{
    result.Show = true;
    return Results.Ok(db.Order.ToList());

    //if (db.Order.Any())
    //{
    //  result.Show = true;
    //}
    //else
    //{
    //  result.Show =false;
    //}

});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
