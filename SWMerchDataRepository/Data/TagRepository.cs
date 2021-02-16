using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository.Data
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
        }
    }
}
