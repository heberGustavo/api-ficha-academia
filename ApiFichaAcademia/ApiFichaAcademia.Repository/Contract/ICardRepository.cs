using ApiFichaAcademia.Models.DTO;
using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface ICardRepository
	{
		Task<List<CardDTO>> GetAll();
		Task<CardDTO> GetById(int id);

		Task<Card> Create(Card card);
		Task<Card> Update(Card card);
		Task<Card> Delete(int id);
	}
}
