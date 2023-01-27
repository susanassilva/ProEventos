var builder = WebApplication.CreateBuilder(args); //createbuilder vem com o IConfiguration para definir qual é o ambiente
//ILoggerFactory => injetado no builder

// Add services to the container.

builder.Services.AddControllers(); //arquitetura MVC
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

app.UseRouting(); //chama a rota do controller

app.MapControllers(); //retorna o endpoint

app.Run();
