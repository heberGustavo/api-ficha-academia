using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFichaAcademia.Business
{
	public class ObjectiveBusiness : IObjectiveBusiness
	{
		#region READ

		public Task<List<ObjectiveDTO>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<ObjectiveDTO> GetById(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region WRITE

		public Task<ObjectiveDTO> Create(ObjectiveDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<ObjectiveDTO> Update(ObjectiveDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<ObjectiveDTO> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion
		
	}
}
