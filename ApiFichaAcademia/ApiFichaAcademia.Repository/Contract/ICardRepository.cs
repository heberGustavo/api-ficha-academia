using ApiFichaAcademia.Models.Model;

namespace ApiFichaAcademia.Repository.Contract
{
	public interface ICardRepository
	{
		Task<List<Card>> GetAll();
		Task<Card> GetById(int id);

		Task<Card> Create(Card card);
		Task<Card> Update(Card card);
		Task<Card> Delete(int id);
	}
}
