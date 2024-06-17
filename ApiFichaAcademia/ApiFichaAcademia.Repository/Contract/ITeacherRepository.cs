using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract.Base;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface ITeacherRepository : IBaseRepository<Teacher, TeacherDTO>
	{
	}
}
