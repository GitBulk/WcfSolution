using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public abstract class Validatable
    {
        protected IValidator validator = null;
        protected IEnumerable<ValidationFailure> validityErrors = null;
        protected abstract IValidator GetValidator();

        public IEnumerable<ValidationFailure> ValidityErrors
        {
            get
            {
                return validityErrors;
            }
            set { }
        }

        public void Validate()
        {
            if (this.validator != null)
            {
                ValidationResult result = this.validator.Validate(this);
                validityErrors = result.Errors;
            }
        }

        public virtual bool IsValid
        {
            get
            {
                if (validityErrors != null && validityErrors.Count() > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
