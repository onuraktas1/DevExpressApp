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

            ValidationContext<IEntity> context = new ValidationContext<IEntity>(entity);
            var ValidationResult = validator.Validate(context);

            if (!ValidationResult.IsValid)
            {
                string message = null;
                foreach (var error in ValidationResult.Errors)
                {
                    message += error.ErrorMessage + System.Environment.NewLine;
                }

                result = false;
                errorMessage = message;
            }
            errorMessage = string.Empty;
            return result;
        }
    }
}
