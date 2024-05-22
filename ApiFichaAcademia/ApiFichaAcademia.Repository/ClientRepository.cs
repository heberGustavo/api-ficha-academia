using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;

namespace ApiFichaAcademia.Repository
{
	public class ClientRepository : IClientRepository
	{
		#region READ

		public Task<List<Client>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Client> GetById(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region WRITE

		public Task<Client> Create(Client teacher)
		{
			throw new NotImplementedException();
		}

		public Task<Client> Update(Client teacher)
		{
			throw new NotImplementedException();
		}

		public Task<Client> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
