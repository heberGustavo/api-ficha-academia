using ApiFichaAcademia.Migrations.Context;
using ApiFichaAcademia.Models.DTO;
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

		public async Task<List<ExerciseDTO>> GetAll()
		{
			try
			{
				var query = from exercise in _dbContext.Exercises
							join levelExercise in _dbContext.LevelExercise on exercise.IdLevel equals levelExercise.Id
							select new ExerciseDTO
							{
								Id = exercise.Id,
								IdLevel = exercise.IdLevel,
								Name = exercise.Name,
								NameLevel = levelExercise.Name
							};

				return await query.ToListAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<ExerciseDTO> GetById(int id)
		{
			try
			{
				var query = from exercise in _dbContext.Exercises
							join levelExercise in _dbContext.LevelExercise on exercise.IdLevel equals levelExercise.Id
							where exercise.Id == id
							select new ExerciseDTO
							{
								Id = exercise.Id,
								Name = exercise.Name,
								IdLevel = exercise.IdLevel,
								NameLevel = levelExercise.Name
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

		public async Task<int> Delete(int id)
		{
			try
			{
				var resultItem = await _dbContext.Exercises.FirstOrDefaultAsync(x => x.Id == id);
				if(resultItem != null)
				{
					_dbContext.Exercises.Remove(resultItem);
					return await _dbContext.SaveChangesAsync();
				}

				return 0;
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

	}
}
