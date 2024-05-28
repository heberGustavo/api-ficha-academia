using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface IExerciseRepository
	{
		Task<List<Exercise>> GetAll();
		Task<Exercise> GetById(int id);

		Task<Exercise> Create(Exercise exercise);
		Task<Exercise> Update(Exercise exercise);
		Task<Exercise> Delete(int id);
	}
}
