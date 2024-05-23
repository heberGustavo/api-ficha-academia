using ApiFichaAcademia.Business.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFichaAcademia.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientController : ControllerBase
	{
		private readonly IClientBusiness _clientBusiness;

		public ClientController(IClientBusiness clientBusiness)
		{
			_clientBusiness = clientBusiness;
		}

		[HttpGet]
		public async Task<ActionResult> GetAll()
		{
			var result = await _clientBusiness.GetAll();
			return Ok(result);
		}
	}
}
