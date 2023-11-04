using Inventory.Core.Entities;
using Inventory.Infrastructore.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

builder.Services.AddDbContext<InventoryDB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainDB"));
});


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapPost("/newOrder", async (InventoryDB db , Order order) => new
{
    
});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
