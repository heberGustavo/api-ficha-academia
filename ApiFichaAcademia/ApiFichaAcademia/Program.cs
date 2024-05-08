using ApiFichaAcademia.Migrations.Context;
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
