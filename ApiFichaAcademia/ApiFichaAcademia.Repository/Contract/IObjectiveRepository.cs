using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface IObjectiveRepository
	{
		Task<ObjectiveDTO> GetById(int id);
		Task<List<ObjectiveDTO>> GetAll();
		Task<Objective> Create(Objective model);
		Task<Objective> Update(Objective model);
		Task<Objective> Delete(int id);
	}
}
