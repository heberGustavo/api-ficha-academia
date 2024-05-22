using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
	public interface IClientBusiness
	{
		Task<ResultInfoItem<ClientDTO>> GetById(int id);
		Task<ResultInfoList<ClientDTO>> GetAll();
		Task<ResultInfoItem<ClientDTO>> Create(ClientDTO model);
		Task<ResultInfoItem<ClientDTO>> Update(ClientDTO model);
		Task<ResultInfoItem<ClientDTO>> Delete(int id);
	}
}
