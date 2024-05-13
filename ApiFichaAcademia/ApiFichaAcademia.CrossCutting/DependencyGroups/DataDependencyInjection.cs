using ApiFichaAcademia.Repository.Contract;
using ApiFichaAcademia.Repository.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace ApiFichaAcademia.CrossCutting.DependencyGroups
{
	public class DataDependencyInjection
	{
		public static void Register(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<ITeacherRepository, TeacherRepository>();
		}
	}
}
