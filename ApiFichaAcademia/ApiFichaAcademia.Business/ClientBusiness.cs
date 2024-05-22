using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business
{
	public class ClientBusiness : IClientBusiness
	{
		#region READ

		public Task<ResultInfoList<ClientDTO>> GetAll()
		{
			throw new NotImplementedException();
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
