using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using AutoMapper;

namespace ApiFichaAcademia.CrossCutting.MappingGroups
{
	public class DataToDomain : Profile
	{
        public DataToDomain()
        {
            CreateMap<Teacher, TeacherDTO>();
            CreateMap<Client, ClientDTO>();
        }
    }
}
