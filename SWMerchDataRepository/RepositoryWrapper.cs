using SWMerchDataRepository.Contracts;
using SWMerchDataRepository.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SWMerchDataRepository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationDbContext _context;
        private ICustomerRepository _customer;
        private IOrderRepository _order;
        private IProductRepository _product;
        private IPurchasedProductRepository _purchasedProduct;
        private IAdvancedUserSettingsRepository _advancedUserSettings;
        private ITagRepository _tag;
        private IProductTagRepository _productTag;
        private ICartRepository _cart;
        private IProductInCartRepository _productInCart;
        private ICardRepository _card;
        private IAddressRepository _address;

        public ICustomerRepository Customer
        {
            get
            {
                if(_customer == null)
                {
                    _customer = new CustomerRepository(_context);
                }
                return _customer;
            }
        }

        public IOrderRepository Order
        {
            get
            {
                if(_order == null)
                {
                    _order = new OrderRepository(_context);
                }
                return _order;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if(_product == null)
                {
                    _product = new ProductRepository(_context);
                }
                return _product;
            }
        }

        public IPurchasedProductRepository PurchasedProduct
        {
            get
            {
                if(_purchasedProduct == null)
                {
                    _purchasedProduct = new PurchasedProductRepository(_context);
                }
                return _purchasedProduct;
            }
        }

        public IAdvancedUserSettingsRepository AdvancedUserSettings
        {
            get
            {
                if(_advancedUserSettings == null)
                {
                    _advancedUserSettings = new AdvancedUserSettingsRepository(_context);
                }
                return _advancedUserSettings;
            }
        }

        public ITagRepository Tag
        {
            get
            {
                if(_tag == null)
                {
                    _tag = new TagRepository(_context);
                }
                return _tag;
            }
        }

        public IProductTagRepository ProductTag
        {
            get
            {
                if(_productTag == null)
                {
                    _productTag = new ProductTagRepository(_context);
                }
                return _productTag;
            }
        }
        public ICartRepository Cart
        {
            get
            {
                if(_cart == null)
                {
                    _cart = new CartRepository(_context);
                }
                return _cart;
            }
        }
        public IProductInCartRepository ProductInCart
        {
            get
            {
                if(_productInCart == null)
                {
                    _productInCart = new ProductInCartRepository(_context);
                }
                return _productInCart;
            }
        }
        public ICardRepository Card
        {
            get
            {
                if(_card == null)
                {
                    _card = new CardRepository(_context);
                }
                return _card;
            }
        }
        public IAddressRepository Address
        {
            get
            {
                if (_address == null)
                {
                    _address = new AddressRepository(_context);
                }
                return _address;
            }
        }

        public RepositoryWrapper(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
