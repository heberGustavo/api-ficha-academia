using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFichaAcademia.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ExerciseController : ControllerBase
	{
		private readonly IExerciseBusiness _exerciseBusiness;

		public ExerciseController(IExerciseBusiness exerciseBusiness)
		{
			_exerciseBusiness = exerciseBusiness;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(ResultInfoList<ExerciseDTO>))]
		[ProducesResponseType(400)]
		public async Task<ActionResult> GetAll()
		{
			var result = await _exerciseBusiness.GetAll();
			if (!result.Status)
				return BadRequest(result);

			return Ok(result);
		}
	}
}
