using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId = 1,CategoryId=1, ProductName="Bardak",UnıtPrice=15,UnitsInStock=15},
                new Product{ProductId = 2,CategoryId=2, ProductName="Kamera",UnıtPrice=500,UnitsInStock=3},
                new Product{ProductId = 3,CategoryId=3, ProductName="Telefon",UnıtPrice=1500,UnitsInStock=2},
                new Product{ProductId = 4,CategoryId=4, ProductName="Klavye",UnıtPrice=150,UnitsInStock=65},
                new Product{ProductId = 5,CategoryId=5, ProductName="Fare",UnıtPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {//LING 
         //lambda           
           Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

           _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {//gönderdiğim ürün ıd sine sahip olan listedeki ürünü bul demek
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnıtPrice = product.UnıtPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
