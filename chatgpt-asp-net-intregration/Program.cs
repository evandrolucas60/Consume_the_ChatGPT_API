using ChatGPT.ASP.NET.Integration.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddSerilog(builder.Configuration, "ChatGPT ASP.NET 8 Integration");
builder.AddChatGpt(/*builder.Configuration*/);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
