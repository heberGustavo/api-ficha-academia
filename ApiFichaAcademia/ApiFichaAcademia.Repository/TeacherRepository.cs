using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Repository
{
	public class TeacherRepository : ITeacherRepository
    {
        private readonly DbContext _dbContext;

		public TeacherRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#region READ

		public async Task<List<Teacher>> GetAll() => await _dbContext.Set<Teacher>().ToListAsync();

        public async Task<Teacher> GetById(int id) => await _dbContext.Set<Teacher>().FirstOrDefaultAsync(x => x.Id == id);

        #endregion

        #region WRITE

        public async Task<Teacher> Create(Teacher teacher)
        {
            await _dbContext.Set<Teacher>().AddAsync(teacher);
            await _dbContext.SaveChangesAsync();

            return teacher;
        }

        public async Task<Teacher> Update(Teacher teacher)
        {
            var result = await GetById(teacher.Id);
            if (result != null)
            {
                try
                {
                    _dbContext.Set<Teacher>().Entry(result).CurrentValues.SetValues(teacher);
                    await _dbContext.SaveChangesAsync();
                    return teacher;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else 
                return null;

        }

        public async Task<Teacher> Delete(int id)
        {
            var result = await GetById(id);
            if (result != null)
            {
                _dbContext.Set<Teacher>().Remove(result);
                await _dbContext.SaveChangesAsync();
                return result;
            }
            else
                return null;
        }

        #endregion

    }
}
