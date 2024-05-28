using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using AutoMapper;

namespace ApiFichaAcademia.CrossCutting.MappingGroups
{
	public class DomainToData : Profile
	{
        public DomainToData()
        {
            CreateMap<TeacherDTO, Teacher>();
            CreateMap<ClientDTO, Client>();
            CreateMap<ObjectiveDTO, Objective>();
            CreateMap<ExerciseDTO, Exercise>();
        }
    }
}
