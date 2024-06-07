using ApiFichaAcademia.Business.Contract;
using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFichaAcademia.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CardController : ControllerBase
	{
		private readonly ICardBusiness _cardBusiness;

		public CardController(ICardBusiness cardBusiness)
		{
			_cardBusiness = cardBusiness;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(ResultInfoList<CardDTO>))]
		[ProducesResponseType(400)]
		public async Task<ActionResult> GetAll()
		{
			var result = await _cardBusiness.GetAll();
			if (!result.Status)
				return BadRequest(result);

			return Ok(result);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult> GetById(int id)
		{
			var result = await _cardBusiness.GetById(id);
			if (!result.Status)
				return BadRequest(result);
			else if (result.Data == null)
				return NotFound(result);

			return Ok(result);
		}

		[HttpPost]
		public async Task<ActionResult> Create([FromBody] CardDTO model)
		{
			var result = await _cardBusiness.Create(model);
			if(!result.Status) return BadRequest(result);

			return Ok(result);
		}

		[HttpPut]
		public async Task<ActionResult> Update([FromBody] CardDTO model)
		{
			var result = await _cardBusiness.Update(model);
			if (!result.Status) 
				return BadRequest(result);
			else if(result.Data == null)
				return NotFound(result);

			return Ok(result);	
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			var result = await _cardBusiness.Delete(id);
			if (!result.Status)
				return BadRequest(result);
			else if (result.Data == null)
				return NotFound(result);

			return Ok(result);
		}
	}
}
