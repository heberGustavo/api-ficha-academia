using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ApiFichaAcademia.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TeacherController : ControllerBase
	{
		private readonly ITeacherBusiness _teacherBusiness;

		public TeacherController(ITeacherBusiness teacherBusiness)
		{
			_teacherBusiness = teacherBusiness;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(ResultInfoList<TeacherDTO>))]
		public async Task<ActionResult> GetAll()
		{
			var result = await _teacherBusiness.GetAll();
			return Ok(result);
		}

		[HttpGet("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(404)]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _teacherBusiness.GetById(id);
			if (result.Data == null) return NotFound();

			return Ok(result);
		}

		[HttpPost]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(400)]
		public async Task<ActionResult> Create([FromBody] TeacherDTO model)
		{
			var result = await _teacherBusiness.Create(model);
			if (result.Data == null || result.Data.Id <= 0) return BadRequest();
			return Ok(result);
		}

		[HttpPut]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(404)]
		public async Task<ActionResult> Update([FromBody] TeacherDTO model)
		{
			var result = await _teacherBusiness.Update(model);
			if (result.Data == null || result.Data.Id <= 0) return NotFound();

			return Ok(result);
		}

		[HttpDelete("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		public async Task<ActionResult> Delete(int id)
		{
			var result = await _teacherBusiness.Delete(id);
			return Ok(result);
		}
	}
}
