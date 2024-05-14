using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using AutoMapper;

namespace ApiFichaAcademia.Business
{
	public class TeacherBusiness : ITeacherBusiness
	{
		private readonly ITeacherRepository _teacherRepository;
		private readonly IMapper _mapper;

		public TeacherBusiness(ITeacherRepository teacherRepository, IMapper mapper)
		{
			_teacherRepository = teacherRepository;
			_mapper = mapper;
		}

		#region READ

		public async Task<List<TeacherDTO>> GetAll()
		{
			return _mapper.Map<List<TeacherDTO>>(await _teacherRepository.GetAll());
		}

		public async Task<TeacherDTO> GetById(int id)
		{
			if (id <= 0) return new TeacherDTO();

			return _mapper.Map<TeacherDTO>(await _teacherRepository.GetById(id));
		}

		#endregion

		#region WRITE

		public Task<TeacherDTO> Create(TeacherDTO model)
		{
			throw new NotImplementedException();
		}

		public Task<TeacherDTO> Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Task<TeacherDTO> Update(TeacherDTO model)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
