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
