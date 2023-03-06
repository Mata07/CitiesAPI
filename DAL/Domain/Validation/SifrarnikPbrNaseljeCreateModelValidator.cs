using System;
using FluentValidation;
using Hp.Domain.Models;

namespace Hp.Domain.Validation
{
    public partial class SifrarnikPbrNaseljeCreateModelValidator
        : AbstractValidator<SifrarnikPbrNaseljeCreateModel>
    {
        public SifrarnikPbrNaseljeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Naselje).MaximumLength(512);
            #endregion
        }

    }
}
