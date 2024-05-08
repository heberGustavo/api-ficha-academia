using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using ApiFichaAcademia.Repository.Contract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Repository.Implementation
{
	public class TeacherRepository : IBaseRepository<Teacher>, ITeacherRepository
	{
        

        #region READ

        public Task<Teacher> GetAll()
		{
			throw new NotImplementedException();
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
