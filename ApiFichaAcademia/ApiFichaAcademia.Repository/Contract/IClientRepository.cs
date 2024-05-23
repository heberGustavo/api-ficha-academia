using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract.Base;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface IClientRepository
	{
		Task<List<Client>> GetAll();
		Task<Client> GetById(int id);

		Task<Client> Create(Client teacher);
		Task<Client> Update(Client teacher);
		Task<Client> Delete(int id);
	}
}
