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
		public async Task<ActionResult> Get()
		{
			var result = await _teacherBusiness.GetAll();
			return Ok(result);
		}
	}
}
