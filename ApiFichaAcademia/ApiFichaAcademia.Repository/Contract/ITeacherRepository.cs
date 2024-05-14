using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface ITeacherRepository
	{
		Task<List<Teacher>> GetAll();
		Task<Teacher> GetById(int id);
			 
		Task<Teacher> Create(Teacher teacher);
		Task<Teacher> Update(Teacher teacher);
		Task<Teacher> Delete(int id);
	}
}
