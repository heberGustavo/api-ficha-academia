using ApiFichaAcademia.Common.Utils;
using ApiFichaAcademia.Models.DTO;

namespace ApiFichaAcademia.Business.Contract
{
	public interface ICardBusiness
	{
		Task<ResultInfoItem<CardDTO>> GetById(int id);
		Task<ResultInfoList<CardDTO>> GetAll();
		Task<ResultInfoItem<CardDTO>> Create(CardDTO model);
		Task<ResultInfoItem<CardDTO>> Update(CardDTO model);
		Task<ResultInfoItem<CardDTO>> Delete(int id);
	}
}
