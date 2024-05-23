using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using AutoMapper;

namespace ApiFichaAcademia.Business
{
	public class ClientBusiness : IClientBusiness
	{
		private readonly IClientRepository _clientRepository;
		private readonly IMapper _mapper;

		public ClientBusiness(IClientRepository clientRepository, IMapper mapper)
		{
			_clientRepository = clientRepository;
			_mapper = mapper;
		}

		#region READ

		public async Task<ResultInfoList<ClientDTO>> GetAll()
		{
			var result = new ResultInfoList<ClientDTO>();

			try
			{
				result.Data =  _mapper.Map<List<ClientDTO>>(await _clientRepository.GetAll());
				result.QuantData = result.Data.Count;
			}
			catch (Exception ex)
			{
				result = new ResultInfoList<ClientDTO>(false, 0, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ClientDTO>> GetById(int id)
		{
			var result = new ResultInfoItem<ClientDTO>();

			try
			{
				result.Data = _mapper.Map<ClientDTO>(await _clientRepository.GetById(id));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ClientDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion

		#region WRITE

		public async Task<ResultInfoItem<ClientDTO>> Create(ClientDTO model)
		{
			var result = new ResultInfoItem<ClientDTO>();

			try
			{
				var entity = _mapper.Map<Client>(model);
				result.Data = _mapper.Map<ClientDTO>(await _clientRepository.Create(entity));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ClientDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<ClientDTO>> Update(ClientDTO model)
		{
			var result = new ResultInfoItem<ClientDTO>();

			try
			{
				var resultItem = await GetById(model.Id);

				if (!resultItem.Status) 
					return resultItem;
				else if (resultItem.Data == null)
				{
					resultItem.Message = "Item not found, please verify and try again!";
					return resultItem;
				}

				var entity = _mapper.Map<Client>(model);
				result.Data = _mapper.Map<ClientDTO>(await _clientRepository.Update(entity));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<ClientDTO>(false, ex.Message);
			}

			return result;
		}

		public Task<ResultInfoItem<ClientDTO>> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
