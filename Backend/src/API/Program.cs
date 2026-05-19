using FluentValidation.AspNetCore;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using Infrastructure.Services;
using Application.Interfaces;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// DATABASE

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));


// CONTROLLERS

builder.Services.AddControllers();


// SWAGGER

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();




// DEPENDENCY INJECTION

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddScoped<IFileService, FileService>();


// CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});



var app = builder.Build();


// SWAGGER

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}


app.UseStaticFiles();


app.UseCors("AllowAll");


app.UseHttpsRedirection();


app.UseAuthorization();


app.MapControllers();

app.Run();