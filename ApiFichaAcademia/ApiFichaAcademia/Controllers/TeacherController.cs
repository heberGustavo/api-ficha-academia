using ApiFichaAcademia.Business.Contract;
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
	}
}
