using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Business.Concrete.EntityFramework
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Delete(product);       
        }

        public List<Product> GetAll()
        {
            //Business code
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryıd)
        {
            return _productDal.GetAll(p=>p.CategoryId==categoryıd);
        }

        public List<Product> GetProductsByName(string productname)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productname.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
