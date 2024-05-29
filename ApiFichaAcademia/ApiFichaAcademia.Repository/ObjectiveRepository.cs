using ApiFichaAcademia.Migrations.Context;
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
		private readonly FichaAcademiaContext _dbContext;

		public ObjectiveRepository(FichaAcademiaContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<Objective>> GetAll()
		{
			return await _dbContext.Objectives.ToListAsync();
		}

		public async Task<Objective> GetById(int id)
		{
			try
			{
				return await _dbContext.Objectives.FirstOrDefaultAsync(x => x.Id == id);
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
				await _dbContext.Objectives.AddAsync(model);
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
				_dbContext.Objectives.Entry(resultItem).CurrentValues.SetValues(model);
				await _dbContext.SaveChangesAsync();
				return model;
			}

			return null;
		}

		public async Task<Objective> Delete(int id)
		{
			var resultItem = await GetById(id);
			if(resultItem != null)
			{
				_dbContext.Remove(resultItem);
				await _dbContext.SaveChangesAsync();
				return resultItem;
			}

			return null;
		}

		#endregion

	}
}
