﻿using ApiFichaAcademia.Repository;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace ApiFichaAcademia.CrossCutting.DependencyGroups
{
    public class DataDependencyInjection
	{
		public static void Register(IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<ITeacherRepository, TeacherRepository>();
			serviceCollection.AddScoped<IClientRepository, ClientRepository>();
			serviceCollection.AddScoped<IObjectiveRepository, ObjectiveRepository>();
			serviceCollection.AddScoped<IExerciseRepository, ExerciseRepository>();
			serviceCollection.AddScoped<ICardRepository, CardRepository>();
		}
	}
}
