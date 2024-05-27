using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFichaAcademia.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ObjectiveController : ControllerBase
	{
		private readonly IObjectiveBusiness _objectiveBusiness;

		public ObjectiveController(IObjectiveBusiness objectiveBusiness)
		{
			_objectiveBusiness = objectiveBusiness;
		}

		[HttpGet]
		public async Task<ActionResult> GetAll()
		{
			var result = await _objectiveBusiness.GetAll();
			if(!result.Status) return BadRequest(result);

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _objectiveBusiness.GetById(id);
			if (!result.Status)
				return BadRequest(result);
			else if (result.Data == null)
				return NotFound(result);

			return Ok(result);
		}

		[HttpPost]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ObjectiveDTO>))]
		public async Task<ActionResult> Create([FromBody] ObjectiveDTO model)
		{
			var result = await _objectiveBusiness.Create(model);
			if(!result.Status) return BadRequest(result);

			return Ok(result);
		}

	}
}
