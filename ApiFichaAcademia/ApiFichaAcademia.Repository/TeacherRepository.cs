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

		public async Task<List<Teacher>> GetAll()
        {
            try
            {
				var result = await _dbContext.Set<Teacher>().ToListAsync();
				return result;
			}
            catch (Exception e)
            {
                throw;
            }
		}

        public Task<Teacher> GetById(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region WRITE

        public Task<Teacher> Create(Teacher teacher)
        {
            throw new NotImplementedException();
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
