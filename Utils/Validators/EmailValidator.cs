using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using webTRON_Management_Software.Models;

namespace webTRON_Management_Software.Utils.Validators
{
    class EmailValidator : AbstractValidator<UserEmail>
    {
        public EmailValidator()
        {
            RuleFor(UserEmail => UserEmail.value).EmailAddress().WithMessage("Invalid Email Format.");
        }
    }
}
