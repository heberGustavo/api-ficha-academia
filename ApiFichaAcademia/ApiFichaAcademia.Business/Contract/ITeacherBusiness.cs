using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Common.Utils.ResultInfo;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
    public interface ITeacherBusiness
	{
		Task<TeacherDTO> GetById(int id);
		Task<ResultInfoList<TeacherDTO>> GetAll();
		Task<TeacherDTO> Create(TeacherDTO model);
		Task<TeacherDTO> Update(TeacherDTO model);
		Task<TeacherDTO> Delete(int id);
	}
}
