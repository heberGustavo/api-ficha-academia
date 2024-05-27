using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
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

		public Task<ResultInfoList<ObjectiveDTO>> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<ResultInfoItem<ObjectiveDTO>> GetById(int id)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region WRITE

		public Task<ResultInfoItem<ObjectiveDTO>> Create(ObjectiveDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<ResultInfoItem<ObjectiveDTO>> Update(ObjectiveDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<ResultInfoItem<ObjectiveDTO>> Delete(int id)
		{
			throw new NotImplementedException();
		}

		#endregion
		
	}
}
