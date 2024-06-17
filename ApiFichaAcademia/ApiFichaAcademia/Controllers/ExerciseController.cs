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

		[HttpGet("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ExerciseDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _exerciseBusiness.GetById(id);
			if (!result.Status)
				return BadRequest(result);
			else if (result.Data == null)
				return NotFound(result);

			return Ok(result);
		}

		[HttpPost]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ExerciseDTO>))]
		[ProducesResponseType(400)]
		public async Task<ActionResult> Create([FromBody] ExerciseDTO model)
		{
			var result = await _exerciseBusiness.Create(model);
			if(!result.Status) return BadRequest(result);

			return Ok(result);
		}

		[HttpPut]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ExerciseDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> Update([FromBody] ExerciseDTO model)
		{
			var result = await _exerciseBusiness.Update(model);
			if (!result.Status) 
				return BadRequest(result);
			else if(result.Data == null)
				return NotFound(result);

			return Ok(result);	
		}

		[HttpDelete("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ExerciseDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> Delete(int id)
		{
			var result = await _exerciseBusiness.Delete(id);
			if (!result.Status)
				return BadRequest(result);
			else if (result.Data == null)
				return NotFound(result);

			return Ok(result);
		}
	}
}
