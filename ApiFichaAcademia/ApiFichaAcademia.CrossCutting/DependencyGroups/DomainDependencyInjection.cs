using ApiFichaAcademia.Business;
using ApiFichaAcademia.Business.Contract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.CrossCutting.DependencyGroups
{
	public class DomainDependencyInjection
	{
		public static void Register(IServiceCollection serviceCollection)
		{
			serviceCollection.AddScoped<ITeacherBusiness, TeacherBusiness>();
			serviceCollection.AddScoped<IClientBusiness, ClientBusiness>();
			serviceCollection.AddScoped<IObjectiveBusiness, ObjectiveBusiness>();
			serviceCollection.AddScoped<IExerciseBusiness, ExerciseBusiness>();
		}
	}
}
