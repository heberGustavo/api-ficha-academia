using ApiFichaAcademia.Migrations.Context;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiFichaAcademia.Repository
{
	public class ExerciseRepository : IExerciseRepository
	{
		private readonly FichaAcademiaContext _dbContext;

		public ExerciseRepository(FichaAcademiaContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<Exercise>> GetAll()
		{
			try
			{
				return await _dbContext.Exercises.ToListAsync();
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
				return await _dbContext.Exercises.FirstOrDefaultAsync(x => x.Id == id);
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
				await _dbContext.Exercises.AddAsync(exercise);
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
				var resultItem = await _dbContext.Exercises.FirstAsync(x => x.Id == exercise.Id);
				if(resultItem != null)
				{
					_dbContext.Entry(resultItem).CurrentValues.SetValues(exercise);
					await _dbContext.SaveChangesAsync();
					return exercise;
				}

				return null;
			}
			catch (Exception ex)
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
					_dbContext.Exercises.Remove(resultItem);
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
