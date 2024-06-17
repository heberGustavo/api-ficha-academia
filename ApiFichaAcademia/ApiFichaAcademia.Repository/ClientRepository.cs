using ApiFichaAcademia.Migrations.Context;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Repository
{
	public class ClientRepository : IClientRepository
	{
		private readonly FichaAcademiaContext _dbContext;

		public ClientRepository(FichaAcademiaContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<ClientDTO>> GetAll()
		{
			try
			{
				var query = from client in _dbContext.Clients
							select new ClientDTO
							{
								Id = client.Id,
								Name = client.Name,
								Age = client.Age,
								WeeklyFrequency = client.WeeklyFrequency,
								Weight = client.Weight,
							};

				return await query.ToListAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public Task<ClientDTO> GetById(int id)
		{
			try
			{
				var query = from client in _dbContext.Clients
							where client.Id == id
							select new ClientDTO
							{
								Id = client.Id,
								Name = client.Name,
								Age = client.Age,
								WeeklyFrequency = client.WeeklyFrequency,
								Weight = client.Weight,
							};

				return query.FirstOrDefaultAsync();
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
				await _dbContext.Clients.AddAsync(client);
				await _dbContext.SaveChangesAsync();
				return client;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Client> Update(Client client)
		{
			try
			{
				var resultItem = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == client.Id);
				if(resultItem != null)
				{
					_dbContext.Clients.Entry(resultItem).CurrentValues.SetValues(client);
					await _dbContext.SaveChangesAsync();
					return client;
				}

				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Client> Delete(int id)
		{
			var resultItem = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == id);
			if(resultItem != null )
			{
				_dbContext.Clients.Remove(resultItem);
				await _dbContext.SaveChangesAsync();
				return resultItem;
			}

			return null;
		}

		#endregion
	}
}
