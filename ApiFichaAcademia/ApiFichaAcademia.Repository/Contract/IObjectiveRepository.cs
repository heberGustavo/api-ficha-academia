using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface IObjectiveRepository
	{
		Task<Objective> GetById(int id);
		Task<List<Objective>> GetAll();
		Task<Objective> Create(Objective model);
		Task<Objective> Update(Objective model);
		Task<Objective> Delete(int id);
	}
}
