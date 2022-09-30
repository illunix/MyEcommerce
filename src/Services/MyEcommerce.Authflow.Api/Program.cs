using Microsoft.AspNetCore.OpenApi;
using MyEcommerce.Shared.Infrastructure.Request;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddHttpRequests(typeof(Program))
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();