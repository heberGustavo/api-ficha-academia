using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
	public interface IExerciseBusiness
	{
		Task<ResultInfoList<ExerciseDTO>> GetAll();
		Task<ResultInfoItem<ExerciseDTO>> GetById(int id);

		Task<ResultInfoItem<ExerciseDTO>> Create(ExerciseDTO exercise);
		Task<ResultInfoItem<ExerciseDTO>> Update(ExerciseDTO exercise);
		Task<ResultInfoItem<ExerciseDTO>> Delete(int id);
	}
}
