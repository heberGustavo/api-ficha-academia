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
		[ProducesResponseType(400)]
		public async Task<ActionResult> GetAll()
		{
			var result = await _teacherBusiness.GetAll();
			if (!result.Status) return BadRequest(result);

			return Ok(result);
		}

		[HttpGet("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _teacherBusiness.GetById(id);
			if (!result.Status) 
				return BadRequest(result);
			else if (result.Data == null) 
				return NotFound(result);

			return Ok(result);
		}

		[HttpPost]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(400)]
		public async Task<ActionResult> Create([FromBody] TeacherDTO model)
		{
			var result = await _teacherBusiness.Create(model);
			if (!result.Status || result.Data == null) return BadRequest(result);
			
			return Ok(result);
		}

		[HttpPut]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> Update([FromBody] TeacherDTO model)
		{
			var result = await _teacherBusiness.Update(model);
			if (!result.Status) 
				return BadRequest(result);
			else if (result.Data == null) 
				return NotFound(result);

			return Ok(result);
		}

		[HttpDelete("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<TeacherDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> Delete(int id)
		{
			var result = await _teacherBusiness.Delete(id);
			if (!result.Status)
				return BadRequest(result);
			else if (result.Data == null)
				return NotFound(result);

			return Ok(result);
		}
	}
}