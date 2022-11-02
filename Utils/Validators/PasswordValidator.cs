using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTRON_Management_Software.Models;

namespace webTRON_Management_Software.Utils.Validators
{
    class PasswordValidator : AbstractValidator<Password>
    {
        //Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character
        string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        public PasswordValidator()
        {
            RuleFor(Password => Password.value).Matches(regexPattern).WithMessage("Invalid Password.");
        }
    }
}
