using ApiFichaAcademia.Business.Contract;
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
		public async Task<ActionResult> GetAll()
		{
			var result = await _teacherBusiness.GetAll();
			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _teacherBusiness.GetById(id);
			if (result == null || result.Id <= 0) return NotFound();

			return Ok(result);
		}

		[HttpPost]
		public async Task<ActionResult> Create([FromBody] TeacherDTO model)
		{
			var result = await _teacherBusiness.Create(model);
			return Ok(result);
		}

		[HttpPut]
		public async Task<ActionResult> Update([FromBody] TeacherDTO model)
		{
			var result = await _teacherBusiness.Update(model);
			if (result == null || result.Id <= 0) return NotFound();

			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var result = await _teacherBusiness.Delete(id);
			return Ok(result);
		}
	}
}
