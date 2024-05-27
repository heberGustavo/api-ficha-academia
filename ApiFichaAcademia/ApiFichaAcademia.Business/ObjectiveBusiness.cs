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

		public Task<ResultInfoList<ObjectiveDTO>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<ResultInfoItem<ObjectiveDTO>> GetById(int id)
		{
			throw new NotImplementedException();
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

		public Task<ResultInfoItem<ObjectiveDTO>> Update(ObjectiveDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<ResultInfoItem<ObjectiveDTO>> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion
		
	}
}
