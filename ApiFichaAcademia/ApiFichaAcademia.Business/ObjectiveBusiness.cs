using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Helpers;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Business
{
	public class ObjectiveBusiness : IObjectiveBusiness
	{
		private readonly IObjectiveRepository _objectiveRepository;
		private readonly IMapper _mapper;

		public ObjectiveBusiness(IObjectiveRepository objectiveRepository, IMapper mapper)
		{
			_objectiveRepository = objectiveRepository;
			_mapper = mapper;
		}

		#region READ

		public async Task<ResultInfoList<ObjectiveDTO>> GetAll()
		{
			var result = new ResultInfoList<ObjectiveDTO>();

			try
			{
				result.Data = await _objectiveRepository.GetAll();
				result.QuantData = result.Data.Count;
			}
			catch (Exception ex)
			{
				result = new ResultInfoList<ObjectiveDTO>(false, 0, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ObjectiveDTO>> GetById(int id)
		{
			var result = new ResultInfoItem<ObjectiveDTO>();

			try
			{
				result.Data = await _objectiveRepository.GetById(id);
				result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ObjectiveDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion

		#region WRITE

		public async Task<ResultInfoItem<ObjectiveDTO>> Create(ObjectiveDTO model)
		{
			var result = new ResultInfoItem<ObjectiveDTO>();

			try
			{
				var entity = _mapper.Map<Objective>(model);
				result.Data = _mapper.Map<ObjectiveDTO>(await _objectiveRepository.Create(entity));
				result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ObjectiveDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ObjectiveDTO>> Update(ObjectiveDTO model)
		{
			var result = new ResultInfoItem<ObjectiveDTO>();

			try
			{
				var resultItem = await _objectiveRepository.GetById(model.Id);
				if (resultItem != null)
				{
					var entity = _mapper.Map<Objective>(model);
					result.Data = _mapper.Map<ObjectiveDTO>(await _objectiveRepository.Update(entity));
					result = ValidateHelperResult.ValidateResultItem(result);
				}
				else
					result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ObjectiveDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ObjectiveDTO>> Delete(int id)
		{
			var result = new ResultInfoItem<ObjectiveDTO>();

			try
			{
				var resultItem = await _objectiveRepository.GetById(id);
				if (resultItem != null)
				{
					result.Data = _mapper.Map<ObjectiveDTO>(await _objectiveRepository.Delete(id));
					result = ValidateHelperResult.ValidateResultItem(result);
				}
				else
					result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ObjectiveDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion
		
	}
}
