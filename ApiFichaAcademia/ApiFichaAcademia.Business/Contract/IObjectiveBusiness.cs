using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
	public interface IObjectiveBusiness
	{
		Task<ObjectiveDTO> GetById(int id);
		Task<List<ObjectiveDTO>> GetAll();
		Task<ObjectiveDTO> Create(ObjectiveDTO model);
		Task<ObjectiveDTO> Update(ObjectiveDTO model);
		Task<ObjectiveDTO> Delete(int id);
	}
}
