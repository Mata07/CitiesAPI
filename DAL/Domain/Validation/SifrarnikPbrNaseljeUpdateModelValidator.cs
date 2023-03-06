using System;
using FluentValidation;
using Hp.Domain.Models;

namespace Hp.Domain.Validation
{
    public partial class SifrarnikPbrNaseljeUpdateModelValidator
        : AbstractValidator<SifrarnikPbrNaseljeUpdateModel>
    {
        public SifrarnikPbrNaseljeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Naselje).MaximumLength(512);
            #endregion
        }

    }
}
