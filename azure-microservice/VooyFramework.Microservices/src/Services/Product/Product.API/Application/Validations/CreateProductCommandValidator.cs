using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace VooyFramework.Microservices.Product.API.Application.Validations
{
    public class CreateProductCommandValidator : AbstractValidator<Product.API.Application.Commands.CreateProductCommand>
    {
        public CreateProductCommandValidator(Microsoft.Extensions.Logging.ILogger<CreateProductCommandValidator> logger)
        {
            //RuleFor(command => command).NotEmpty();
           

            //logger.LogTrace("----- INSTANCE CREATED - {ClassName}", GetType().Name);
        }

        private bool BeValidExpirationDate(DateTime dateTime)
        {
            return dateTime >= DateTime.UtcNow;
        }

      
    }
}
