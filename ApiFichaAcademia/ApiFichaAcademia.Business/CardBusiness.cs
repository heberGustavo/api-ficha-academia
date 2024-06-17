using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common;
using ApiFichaAcademia.Common.Helpers;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using AutoMapper;

namespace ApiFichaAcademia.Business
{
	public class CardBusiness : ICardBusiness
	{
		private readonly ICardRepository _cardRepository;
		private readonly IClientRepository _clientRepository;
		private readonly IObjectiveRepository _objectiveRepository;
		private readonly ITeacherRepository _teacherRepository;
		private readonly IMapper _mapper;

		public CardBusiness(ICardRepository cardRepository, IClientRepository clientRepository, IObjectiveRepository objectiveRepository, ITeacherRepository teacherRepository, IMapper mapper)
		{
			_cardRepository = cardRepository;
			_clientRepository = clientRepository;
			_objectiveRepository = objectiveRepository;
			_teacherRepository = teacherRepository;
			_mapper = mapper;
		}


		#region READ

		public async Task<ResultInfoList<CardDTO>> GetAll()
		{
			var result = new ResultInfoList<CardDTO>();

			try
			{
				result.Data = await _cardRepository.GetAll();
				result.QuantData = result.Data.Count;
			}
			catch (Exception ex)
			{
				result = new ResultInfoList<CardDTO>(false, 0, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<CardDTO>> GetById(int id)
		{
			var result = new ResultInfoItem<CardDTO>();

			try
			{
				result.Data = await _cardRepository.GetById(id);
				result = ValidateHelperResult.ValidateResultItem(result);
				if (!result.Status) return result;
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<CardDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion

		#region WRITE

		public async Task<ResultInfoItem<CardDTO>> Create(CardDTO model)
		{
			var result = new ResultInfoItem<CardDTO>();

			try
			{
				result = await VerifyExistingData(model);
				if (!result.Status) return result;

				var entity = _mapper.Map<Card>(model);
				result.Data = _mapper.Map<CardDTO>(await _cardRepository.Create(entity));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<CardDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<CardDTO>> Update(CardDTO model)
		{
			var result = new ResultInfoItem<CardDTO>();

			try
			{
				var resultItem = await GetById(model.Id);
				resultItem = ValidateHelperResult.ValidateResultItem(resultItem);
				if (!resultItem.Status || resultItem.Data == null) return resultItem;

				result = await VerifyExistingData(model);
				if (!result.Status) return result;

				var entity = _mapper.Map<Card>(model);
				result.Data = _mapper.Map<CardDTO>(await _cardRepository.Update(entity));
				result = ValidateHelperResult.ValidateResultItem(result);
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<CardDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<CardDTO>> Delete(int id)
		{
			var result = new ResultInfoItem<CardDTO>();

			try
			{
				var resultItem = await GetById(id);
				if (!resultItem.Status)
					return resultItem;
				else if(resultItem.Data == null)
					return resultItem;

				result.Data = _mapper.Map<CardDTO>(await _cardRepository.Delete(id));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<CardDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion

		#region Private methods

		private async Task<ResultInfoItem<CardDTO>> VerifyExistingData(CardDTO cardDTO)
		{
			var result = new ResultInfoItem<CardDTO>();
			var messageError = string.Empty;

			var resultClient = await _clientRepository.GetById(cardDTO.IdClient);
			var resultObjective = await _objectiveRepository.GetById(cardDTO.IdObjective);
			var resultTeacher = await _teacherRepository.GetById(cardDTO.IdTeacher);

			if (resultClient == null)
				messageError += "Not found client with this code. ";
			if (resultObjective == null)
				messageError += "Not found objective with this code. ";
			if (resultTeacher == null)
				messageError += "Not found teacher with this code. ";

			result.Message = messageError.Trim();
			if (resultClient == null || resultObjective == null || resultTeacher == null)
				result.Status = false;

			return result;
		}

		#endregion
	}
}
