using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using CompendioRpgBr.Banco;
using CompendioRpgBr.Modelos;
using CompendioRpgBr.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CompendioRpgBrContext>((options) =>
{
    options
        .UseMySql(builder.Configuration["ConnectionStrings:RpgNarioDB"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:RpgNarioDB"]))
        .UseLazyLoadingProxies();
});

builder.Services.AddTransient<DAL<Editora>>();
builder.Services.AddTransient<DAL<Sistema>>();
builder.Services.AddTransient<DAL<Genero>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddCors(
        options => options.AddPolicy(
            "wasm",
            policy => policy.WithOrigins([builder.Configuration["BackendUrl"] ?? "http://localhost:5100",
            builder.Configuration["FrontendUrl"] ?? "http://localhost:5091"])
            .AllowAnyMethod()
            .SetIsOriginAllowed(pol => true)
            .AllowAnyHeader()
            .AllowCredentials()));

var app = builder.Build();

app.UseCors("wasm");

app.UseStaticFiles();

app.AddEndpointsEditoras();
app.AddEndPointsSistemas();
app.AddEndPointsGeneros();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
