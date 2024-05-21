using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Common.Utils.ResultInfo;
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

		public async Task<ResultInfoList<TeacherDTO>> GetAll()
		{
			var result = new ResultInfoList<TeacherDTO>();

			try
			{
				result.Data = _mapper.Map<List<TeacherDTO>>(await _teacherRepository.GetAll());
				result.QuantData = result.Data.Count;
			}
			catch (Exception ex)
			{
				result = new ResultInfoList<TeacherDTO>(false, 0, ex.Message);
			}

			return result;
		}

		public async Task<TeacherDTO> GetById(int id)
		{
			if (id <= 0) return null;

			return _mapper.Map<TeacherDTO>(await _teacherRepository.GetById(id));
		}

		#endregion

		#region WRITE

		public async Task<TeacherDTO> Create(TeacherDTO model)
		{
			var modelEntity = _mapper.Map<Teacher>(model);
			var modelDTO = _mapper.Map<TeacherDTO>(await _teacherRepository.Create(modelEntity));
			return modelDTO;
		}

		public async Task<TeacherDTO> Delete(int id)
		{
			if (await GetById(id) == null) return null;

			return _mapper.Map<TeacherDTO>(await _teacherRepository.Delete(id));
		}

		public async Task<TeacherDTO> Update(TeacherDTO model)
		{
			if (await GetById(model.Id) == null) return null;

			var modelEntity = _mapper.Map<Teacher>(model);
			return _mapper.Map<TeacherDTO>(await _teacherRepository.Update(modelEntity));
		}

		#endregion
	}
}
