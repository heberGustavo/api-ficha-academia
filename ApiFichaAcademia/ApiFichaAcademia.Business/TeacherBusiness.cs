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

		public async Task<ResultInfoItem<TeacherDTO>> GetById(int id)
		{
			var result = new ResultInfoItem<TeacherDTO>();

			if (id <= 0) return result;

			try
			{
				result.Data = _mapper.Map<TeacherDTO>(await _teacherRepository.GetById(id));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<TeacherDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion

		#region WRITE

		public async Task<ResultInfoItem<TeacherDTO>> Create(TeacherDTO model)
		{
			var result = new ResultInfoItem<TeacherDTO>();

			try
			{
				var modelEntity = _mapper.Map<Teacher>(model);
				var modelDTO = _mapper.Map<TeacherDTO>(await _teacherRepository.Create(modelEntity));
				result.Data = modelDTO;
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<TeacherDTO>(false, ex.Message);
			}
			
			return result;
		}

		public async Task<ResultInfoItem<TeacherDTO>> Update(TeacherDTO model)
		{
			var result = new ResultInfoItem<TeacherDTO>();

			try
			{
				var selectItem = GetById(model.Id).Result.Data;
				if (selectItem == null) return result;

				var modelEntity = _mapper.Map<Teacher>(model);
				result.Data = _mapper.Map<TeacherDTO>(await _teacherRepository.Update(modelEntity));
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<TeacherDTO>(false, ex.Message);
			}

			return result;
		}

		public async Task<ResultInfoItem<TeacherDTO>> Delete(int id)
		{
			var result = new ResultInfoItem<TeacherDTO>();

			try
			{
				var selectItem = GetById(id).Result.Data;
				if (selectItem == null) return result;

				_mapper.Map<TeacherDTO>(await _teacherRepository.Delete(id));
				result.Message = $"Teacher {selectItem.Name} was deleted!";
			}
			catch (Exception ex)
			{
				result = new ResultInfoItem<TeacherDTO>(false, ex.Message);
			}

			return result;
		}

		#endregion
	}
}
