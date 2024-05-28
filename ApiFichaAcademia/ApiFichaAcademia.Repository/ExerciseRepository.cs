using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Repository
{
	public class ExerciseRepository : IExerciseRepository
	{
		private readonly DbContext _dbContext;

		public ExerciseRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<Exercise>> GetAll()
		{
			try
			{
				return await _dbContext.Set<Exercise>().ToListAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Exercise> GetById(int id)
		{
			try
			{
				return await _dbContext.Set<Exercise>().FirstOrDefaultAsync(x => x.Id == id);
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

		#region WRITE

		public async Task<Exercise> Create(Exercise exercise)
		{
			try
			{
				await _dbContext.Set<Exercise>().AddAsync(exercise);
				await _dbContext.SaveChangesAsync();
				return exercise;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Exercise> Update(Exercise exercise)
		{
			try
			{
				var resultItem = await GetById(exercise.Id);
				if(resultItem != null)
				{
					_dbContext.Set<Exercise>().Entry(resultItem).CurrentValues.SetValues(exercise);
					await _dbContext.SaveChangesAsync();
					return exercise;
				}

				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Exercise> Delete(int id)
		{
			try
			{
				var resultItem = await GetById(id);
				if(resultItem != null)
				{
					_dbContext.Set<Exercise>().Remove(resultItem);
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
