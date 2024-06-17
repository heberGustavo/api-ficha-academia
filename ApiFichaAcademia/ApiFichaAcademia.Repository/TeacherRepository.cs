using ApiFichaAcademia.Migrations.Context;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Repository
{
	public class TeacherRepository : ITeacherRepository
    {
        private readonly FichaAcademiaContext _dbContext;

		public TeacherRepository(FichaAcademiaContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<TeacherDTO>> GetAll()
        {
            try
            {
                var query = from teacher in _dbContext.Teachers
                            select new TeacherDTO
                            {
                                Id = teacher.Id,
                                Name = teacher.Name,
                                Period = teacher.Period,
                                Phone = teacher.Phone,
                            };
                return await query.ToListAsync();
			}
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<TeacherDTO> GetById(int id)
        {
            try
            {
                var query = from teacher in _dbContext.Teachers
                            where teacher.Id == id
							select new TeacherDTO
							{
								Id = teacher.Id,
								Name = teacher.Name,
								Period = teacher.Period,
								Phone = teacher.Phone,
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

        public async Task<Teacher> Create(Teacher teacher)
        {
            try
            {
                await _dbContext.Teachers.AddAsync(teacher);
                await _dbContext.SaveChangesAsync();
                return teacher;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Teacher> Update(Teacher teacher)
        {
            try
            {
                var result = await _dbContext.Teachers.FirstOrDefaultAsync(x => x.Id == teacher.Id);
				if (result != null)
				{
					_dbContext.Teachers.Entry(result).CurrentValues.SetValues(teacher);
					await _dbContext.SaveChangesAsync();
					return teacher;
				}

                return null;
			}
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Teacher> Delete(int id)
        {
            try
            {
                var result = await _dbContext.Teachers.FirstOrDefaultAsync(x => x.Id == id);
				if (result != null)
				{
					_dbContext.Set<Teacher>().Remove(result);
					await _dbContext.SaveChangesAsync();
					return result;
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
