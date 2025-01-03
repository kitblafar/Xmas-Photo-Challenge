﻿using System.Security.Authentication.ExtendedProtection;
using PhotoChallengeAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PhotoChallengeAPIContext>();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                          //policy.WithOrigins( "https://kittyfarren.dev",
                          //                    "http://10.75.12.141:5173/",

                          //                    "http://127.0.0.1:3000/",
                          //                    "http://localhost:3000/",

                          //                    "http://127.0.0.1:5173",
                          //                    "http://localhost:5173/",
                          //                    "http://0.0.0.0:3000/",
                          //                    "http://192.168.0.58:5173/");
                          policy.WithMethods("GET", "POST", "PATCH", "DELETE", "OPTIONS");
                          policy.AllowAnyHeader();
                      });
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);
//app.UseExceptionHandler("/error");

app.UseAuthorization();

app.MapControllers();

app.Run();
