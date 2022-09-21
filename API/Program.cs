using API.DTOs.AutoMapping;
using AutoMapper;
using Infra.Dependeces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Configuracao de banco de dados
builder.Services.ConfigurationDatabaseProject();
//Dependecias repositories
builder.Services.RepositoriesDependeces();


var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);



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
