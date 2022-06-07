using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün Adı Boş Olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Birim Fiyat Boş Olamaz");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Birim Miktar Boş Olamaz");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stok Miktarı Boş Olamaz");

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryId==2);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);

        }
    }
}
