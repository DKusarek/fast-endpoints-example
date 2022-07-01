using fast_endoints_example.Contracts.Requests;
using FastEndpoints;
using FluentValidation;

namespace fast_endoints_example.Validators
{
    public class Validator : Validator<Request>
    {
        public Validator()
        {
            RuleFor(x => x.Ping)
                .NotEmpty().WithMessage("Ping is required")
                .Equal("Ping").WithMessage("Must be ping");

        }
    }
}
