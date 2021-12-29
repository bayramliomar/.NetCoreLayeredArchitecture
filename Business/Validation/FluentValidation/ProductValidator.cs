using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
   public class ProductValidator: AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(3,40);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.ProductName).Must(StartWithAnything);
        }

        public bool StartWithAnything(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
