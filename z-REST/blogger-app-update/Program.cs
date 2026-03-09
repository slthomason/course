using BloggerApp.Application.Interface;
using BloggerApp.Application.Repository;
using BloggerApp.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<DatabaseContext>(options => options.UseSqlServer(builder.Configuration["database"]));

builder.Services.AddTransient<IUserService,UserService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.MapControllers();
app.Run();
