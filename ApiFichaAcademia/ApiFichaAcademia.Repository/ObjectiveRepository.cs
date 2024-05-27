using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Repository
{
	public class ObjectiveRepository : IObjectiveRepository
	{
		#region READ

		public Task<List<Objective>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Objective> GetById(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region WRITE

		public Task<Objective> Create(Objective model)
		{
			throw new NotImplementedException();
		}

		public Task<Objective> Update(Objective model)
		{
			throw new NotImplementedException();
		}

		public Task<Objective> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
