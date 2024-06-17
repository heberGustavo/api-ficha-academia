using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface IExerciseRepository
	{
		Task<List<ExerciseDTO>> GetAll();
		Task<ExerciseDTO> GetById(int id);

		Task<Exercise> Create(Exercise exercise);
		Task<Exercise> Update(Exercise exercise);
		Task<int> Delete(int id);
	}
}
