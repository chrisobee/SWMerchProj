using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Contracts
{
    public interface ICardRepository : IRepositoryBase<Card>
    {
        public Task<List<Card>> GetAllCards(int customerId);

        public Task<Card> GetCardById(int cardId);

        public void InsertCard(Card card);
    }
}
