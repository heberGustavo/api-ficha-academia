using ApiFichaAcademia.Migrations.Context;
using ApiFichaAcademia.Models.DTO;
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

		public async Task<List<ObjectiveDTO>> GetAll()
		{
			var query = from objective in _dbContext.Objectives
						select new ObjectiveDTO
						{
							Id = objective.Id,
							Name = objective.Name,
							Description = objective.Description,
						};

			return await query.ToListAsync();
		}

		public async Task<ObjectiveDTO> GetById(int id)
		{
			try
			{
				var query = from objective in _dbContext.Objectives
							where objective.Id == id
							select new ObjectiveDTO
							{
								Id = objective.Id,
								Name = objective.Name,
								Description = objective.Description,
							};
				return await query.FirstOrDefaultAsync();
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
			try
			{
				var resultItem = await _dbContext.Objectives.FirstOrDefaultAsync(x => x.Id == model.Id);
				if (resultItem != null)
				{
					_dbContext.Objectives.Entry(resultItem).CurrentValues.SetValues(model);
					await _dbContext.SaveChangesAsync();
					return model;
				}

				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Objective> Delete(int id)
		{
			try
			{
				var resultItem = await _dbContext.Objectives.FirstOrDefaultAsync(x => x.Id == id);
				if (resultItem != null)
				{
					_dbContext.Remove(resultItem);
					await _dbContext.SaveChangesAsync();
					return resultItem;
				}

				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

	}
}
