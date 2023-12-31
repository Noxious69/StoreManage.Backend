using Inventory.Backend.DTOs;
using Inventory.Core.Entities;
using Inventory.Infrastructore.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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

builder.Services.AddAuthorization();

var app = builder.Build();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();



app.Run();


