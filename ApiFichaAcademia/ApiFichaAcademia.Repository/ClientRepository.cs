using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Repository
{
	public class ClientRepository : IClientRepository
	{
		private readonly DbContext _dbContext;

		public ClientRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<Client>> GetAll()
		{
			try
			{
				return await _dbContext.Set<Client>().ToListAsync();
			}
			catch (Exception)
			{
				throw;
			}
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
