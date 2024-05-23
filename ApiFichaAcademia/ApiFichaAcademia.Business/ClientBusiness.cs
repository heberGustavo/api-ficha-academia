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

		public Task<ResultInfoItem<ClientDTO>> Update(ClientDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<ResultInfoItem<ClientDTO>> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
