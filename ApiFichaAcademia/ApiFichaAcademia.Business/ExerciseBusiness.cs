using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Helpers;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using AutoMapper;

namespace ApiFichaAcademia.Business
{
	public class ExerciseBusiness : IExerciseBusiness
	{
		private readonly IExerciseRepository _exerciseRepository;
		private readonly IMapper _mapper;

		public ExerciseBusiness(IExerciseRepository exerciseRepository, IMapper mapper)
		{
			_exerciseRepository = exerciseRepository;
			_mapper = mapper;
		}

		#region READ

		public async Task<ResultInfoList<ExerciseDTO>> GetAll()
		{
			var result = new ResultInfoList<ExerciseDTO>();

			try
			{
				result.Data = await _exerciseRepository.GetAll();
				result.QuantData = result.Data.Count;
			}
			catch (Exception ex)
			{
				result = new ResultInfoList<ExerciseDTO>(false, 0, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ExerciseDTO>> GetById(int id)
		{
			var result = new ResultInfoItem<ExerciseDTO>();

			try
			{
				result.Data = await _exerciseRepository.GetById(id);
				result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ExerciseDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion

		#region WRITE

		public async Task<ResultInfoItem<ExerciseDTO>> Create(ExerciseDTO exercise)
		{
			var result = new ResultInfoItem<ExerciseDTO>();

			try
			{
				var entity = _mapper.Map<Exercise>(exercise);

				var resultCreate = _mapper.Map<ExerciseDTO>(await _exerciseRepository.Create(entity));
				if(resultCreate != null)
					result.Data = await _exerciseRepository.GetById(resultCreate.Id);
				
				result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ExerciseDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ExerciseDTO>> Update(ExerciseDTO exercise)
		{
			var result = new ResultInfoItem<ExerciseDTO>();

			try
			{
				var resultItem = await _exerciseRepository.GetById(exercise.Id);
				if (resultItem != null)
				{
					var entity = _mapper.Map<Exercise>(exercise);
					
					var resultUpdate = _mapper.Map<ExerciseDTO>(await _exerciseRepository.Update(entity));
					if (resultUpdate != null)
						result.Data = await _exerciseRepository.GetById(exercise.Id);

					result = ValidateHelperResult.ValidateResultItem(result);
				}
				else
					result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ExerciseDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ExerciseDTO>> Delete(int id)
		{
			var result = new ResultInfoItem<ExerciseDTO>();

			try
			{
				var resultItem = await _exerciseRepository.GetById(id);
				if (resultItem != null)
				{
					var resultDelete = await _exerciseRepository.Delete(id);
					if (resultDelete <= 0)
					{
						result.Status = false;
						result = ValidateHelperResult.ValidateResultItem(result);
						return result;
					}

					result.Data = resultItem;
				}
				else
					result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ExerciseDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion
		
	}
}
