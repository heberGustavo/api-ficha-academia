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

        public Task<Teacher> Update(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> Delete(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
