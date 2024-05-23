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
			try
			{
				return _dbContext.Set<Client>().FirstOrDefaultAsync(x => x.Id == id);
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

		#region WRITE

		public async Task<Client> Create(Client client)
		{
			try
			{
				await _dbContext.Set<Client>().AddAsync(client);
				await _dbContext.SaveChangesAsync();
				return client;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Task<Client> Update(Client client)
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
