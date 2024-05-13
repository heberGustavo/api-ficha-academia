using ApiFichaAcademia.CrossCutting.DependencyGroups;
using ApiFichaAcademia.CrossCutting.MappingGroups;
using ApiFichaAcademia.Migrations.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

#region Database

var connectionString = builder.Configuration.GetConnectionString("FichaAcademiaConection");
services.AddDbContext<FichaAcademiaContext>(options =>
{
	options.UseSqlServer(connectionString);
});

#endregion

#region Mapper

var configurationMapper = new MapperConfiguration(cfg =>
{
	cfg.AddProfile<DomainToData>();
	cfg.AddProfile<DataToDomain>();
});

IMapper mapper = configurationMapper.CreateMapper();
services.AddSingleton(mapper);

#endregion

#region Dependency Injection

DataDependencyInjection.Register(services);
DomainDependencyInjection.Register(services);

#endregion

services.AddControllers();

#region Swagger
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
