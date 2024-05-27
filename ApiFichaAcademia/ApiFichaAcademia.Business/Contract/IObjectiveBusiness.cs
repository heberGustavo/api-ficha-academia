using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
	public interface IObjectiveBusiness
	{
		Task<ResultInfoItem<ObjectiveDTO>> GetById(int id);
		Task<ResultInfoList<ObjectiveDTO>> GetAll();
		Task<ResultInfoItem<ObjectiveDTO>> Create(ObjectiveDTO model);
		Task<ResultInfoItem<ObjectiveDTO>> Update(ObjectiveDTO model);
		Task<ResultInfoItem<ObjectiveDTO>> Delete(int id);
	}
}
