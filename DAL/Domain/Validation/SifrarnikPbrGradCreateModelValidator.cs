using System;
using FluentValidation;
using Hp.Domain.Models;

namespace Hp.Domain.Validation
{
    public partial class SifrarnikPbrGradCreateModelValidator
        : AbstractValidator<SifrarnikPbrGradCreateModel>
    {
        public SifrarnikPbrGradCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NazivPu).MaximumLength(512);
            RuleFor(p => p.AdresaPu).MaximumLength(512);
            RuleFor(p => p.Mjesto).MaximumLength(512);
            RuleFor(p => p.Grad).MaximumLength(512);
            RuleFor(p => p.Zupanija).MaximumLength(512);
            #endregion
        }

    }
}
