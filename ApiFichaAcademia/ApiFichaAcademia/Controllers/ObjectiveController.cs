using ApiFichaAcademia.Business.Contract;
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
		public async Task<ActionResult> Create([FromBody] ObjectiveDTO model)
		{
			throw new NotImplementedException();
		}

	}
}
