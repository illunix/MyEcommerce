using MyEcommerce.Users.API;
using MyEcommerce.Users.Core;
using MyEcommerce.Users.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApi()
    .AddDAL(builder.Configuration)
    .AddCore();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();