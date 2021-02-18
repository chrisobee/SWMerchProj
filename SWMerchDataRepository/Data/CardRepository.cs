using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Data
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
        }
    }
}
