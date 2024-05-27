using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Repository
{
	public class ObjectiveRepository : IObjectiveRepository
	{
		private readonly DbContext _dbContext;

		public ObjectiveRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<Objective>> GetAll()
		{
			return await _dbContext.Set<Objective>().ToListAsync();
		}

		public async Task<Objective> GetById(int id)
		{
			try
			{
				return await _dbContext.Set<Objective>().FirstOrDefaultAsync(x => x.Id == id);
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

		#region WRITE

		public async Task<Objective> Create(Objective model)
		{
			try
			{
				await _dbContext.Set<Objective>().AddAsync(model);
				await _dbContext.SaveChangesAsync();
				return model;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Objective> Update(Objective model)
		{
			var resultItem = await GetById(model.Id);
			if (resultItem != null)
			{
				_dbContext.Set<Objective>().Entry(resultItem).CurrentValues.SetValues(model);
				await _dbContext.SaveChangesAsync();
				return model;
			}

			return null;
		}

		public Task<Objective> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
