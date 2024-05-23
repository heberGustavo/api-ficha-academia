using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
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

		public Task<ResultInfoItem<ClientDTO>> GetById(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region WRITE

		public Task<ResultInfoItem<ClientDTO>> Create(ClientDTO model)
		{
			throw new NotImplementedException();
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
