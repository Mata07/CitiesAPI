using System;
using FluentValidation;
using Hp.Domain.Models;

namespace Hp.Domain.Validation
{
    public partial class SifrarnikGradovaZaPbrCreateModelValidator
        : AbstractValidator<SifrarnikGradovaZaPbrCreateModel>
    {
        public SifrarnikGradovaZaPbrCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Naziv).MaximumLength(512);
            RuleFor(p => p.Zupanija).MaximumLength(512);
            #endregion
        }

    }
}
