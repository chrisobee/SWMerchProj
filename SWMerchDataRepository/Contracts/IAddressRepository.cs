using SWMerchDataRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SWMerchDataRepository.Contracts
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        public Task<List<Address>> GetAllAddresses(int addressId);

        public Task<Address> GetAddressById(int addressId);

        public void InsertAddress(Address address);
    }
}
