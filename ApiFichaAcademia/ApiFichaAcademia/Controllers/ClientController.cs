using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
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
		[ProducesResponseType(200, Type = typeof(ResultInfoList<List<ClientDTO>>))]
		public async Task<ActionResult> GetAll()
		{
			var result = await _clientBusiness.GetAll();
			return Ok(result);
		}

		[HttpGet("{id}")]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ClientDTO>))]
		[ProducesResponseType(404)]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _clientBusiness.GetById(id);
			if(result.Data == null) return NotFound(result);

			return Ok(result);
		}

		[HttpPost]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ClientDTO>))]
		[ProducesResponseType(400)]
		public async Task<ActionResult> Create([FromBody] ClientDTO model)
		{
			var result = await _clientBusiness.Create(model);
			if (result.Data == null || result.Data.Id <= 0) return BadRequest();

			return Ok(result);
		}

		[HttpPut]
		[ProducesResponseType(200, Type = typeof(ResultInfoItem<ClientDTO>))]
		[ProducesResponseType(400)]
		[ProducesResponseType(404)]
		public async Task<ActionResult> Update([FromBody] ClientDTO model)
		{
			var result = await _clientBusiness.Update(model);
			if(!result.Status) 
				return BadRequest(result);
			else if (result.Data == null) 
				return NotFound(result);

			return Ok(result);
		}

	}
}
