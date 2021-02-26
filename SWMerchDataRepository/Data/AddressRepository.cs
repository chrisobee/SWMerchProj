using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Data
{

    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {

        }

        public async Task<List<Address>> GetAllAddresses(int customerId)
        {
            var result = await FindByCondition(c => c.CustomerId == customerId);
            return result.ToList();
        }

        public async Task<Address> GetAddressById(int addressId)
        {
            var result = await FindByCondition(c => c.AddressId == addressId);
            return result.SingleOrDefault();
        }

        public void InsertAddress(Address address) => Create(address);
    }
}
