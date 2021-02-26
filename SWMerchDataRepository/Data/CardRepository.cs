using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Data
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {

        }

        public async Task<List<Card>> GetAllCards(int customerId)
        {
            var result = await FindByCondition(c => c.CustomerId == customerId);
            return result.ToList();
        }

        public async Task<Card> GetCardById( int cardId)
        {
            var result = await FindByCondition(c => c.CardId == cardId);
            return result.SingleOrDefault();
        }

        public void InsertCard(Card card) => Create(card); 
    }
}
