using FluentValidation;
using MicrowaveCommander.API.Dtos.Requests;

namespace MicrowaveCommander.API.Dtos.Validators;

public class CreateCustomProgramRequestValidator : AbstractValidator<CreateCustomProgramRequest>
{
    public CreateCustomProgramRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Meal).NotEmpty();
        RuleFor(x => x.Power).NotEmpty();
        RuleFor(x => x.TimeInMinutes).NotEmpty();
        RuleFor(x => x.ProcessingString)
            .NotEmpty()
            .NotEqual('.');


    }
    
}