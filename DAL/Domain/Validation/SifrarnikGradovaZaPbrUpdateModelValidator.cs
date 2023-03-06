using System;
using FluentValidation;
using Hp.Domain.Models;

namespace Hp.Domain.Validation
{
    public partial class SifrarnikGradovaZaPbrUpdateModelValidator
        : AbstractValidator<SifrarnikGradovaZaPbrUpdateModel>
    {
        public SifrarnikGradovaZaPbrUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Naziv).MaximumLength(512);
            RuleFor(p => p.Zupanija).MaximumLength(512);
            #endregion
        }

    }
}
