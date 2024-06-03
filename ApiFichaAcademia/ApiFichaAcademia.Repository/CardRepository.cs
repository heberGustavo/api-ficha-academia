using ApiFichaAcademia.Migrations.Context;
using ApiFichaAcademia.Models.Model;
using ApiFichaAcademia.Repository.Contract;
using Microsoft.EntityFrameworkCore;

namespace ApiFichaAcademia.Repository
{
	public class CardRepository : ICardRepository
	{
		private readonly FichaAcademiaContext _context;

		#region Constructor
		
		public CardRepository(FichaAcademiaContext context)
		{
			_context = context;
		}

		#endregion

		#region READ

		public async Task<List<Card>> GetAll()
		{
			try
			{
				return await _context.Cards.ToListAsync();
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Card> GetById(int id)
		{
			try
			{
				return await _context.Cards.FirstOrDefaultAsync(x => x.Id == id);
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

		#region WRITE

		public async Task<Card> Create(Card card)
		{
			try
			{
				await _context.Cards.AddAsync(card);
				await _context.SaveChangesAsync();
				return card;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Card> Update(Card card)
		{
			try
			{
				var resultItem = await _context.Cards.FirstOrDefaultAsync(x => x.Id == card.Id);
                if (resultItem != null)
                {
					_context.Entry(resultItem).CurrentValues.SetValues(card);
					await _context.SaveChangesAsync();
					return card;
                }

				return null;
            }
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<Card> Delete(int id)
		{
			try
			{
				var resultItem = await _context.Cards.FirstOrDefaultAsync(x => x.Id == id);
				if(resultItem != null)
				{
					_context.Remove(resultItem);
					await _context.SaveChangesAsync();
					return resultItem;
				}

				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		#endregion

	}
}
