using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Common.Utils.ResultInfo;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
    public interface ITeacherBusiness
	{
		Task<ResultInfoItem<TeacherDTO>> GetById(int id);
		Task<ResultInfoList<TeacherDTO>> GetAll();
		Task<ResultInfoItem<TeacherDTO>> Create(TeacherDTO model);
		Task<ResultInfoItem<TeacherDTO>> Update(TeacherDTO model);
		Task<ResultInfoItem<TeacherDTO>> Delete(int id);
	}
}
