using System.Text.Json.Serialization;
using CompendioRpgBr.Banco;
using CompendioRpgBr.Modelos;
using CompendioRpgBr.API.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CompendioRpgBrContext>();
builder.Services.AddTransient<DAL<Editora>>();
builder.Services.AddTransient<DAL<Sistema>>();
builder.Services.AddTransient<DAL<Genero>>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddCors();
var app = builder.Build();

app.UseCors(options => 
{
    options.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseStaticFiles();

app.AddEndpointsEditoras();
app.AddEndPointsSistemas();
app.AddEndPointsGeneros();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
