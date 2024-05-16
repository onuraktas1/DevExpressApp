using CafeOtomasyon.Entity.Abstract;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Tools
{
    public class ValidatorTools
    {
        public static bool Validates(IValidator validator, IEntity entity, out string errorMessage)
        {
            bool result = true;
            errorMessage = string.Empty;

            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var ValidationResult = validator.Validate(context);

            if (!ValidationResult.IsValid)
            {
                foreach (var error in ValidationResult.Errors)
                {
                    errorMessage += error.ErrorMessage + System.Environment.NewLine;
                }

                result = false;
            }

            return result;
        }
    }
}
