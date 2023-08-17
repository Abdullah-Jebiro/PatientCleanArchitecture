using FluentValidation;

public class PatientValidator : AbstractValidator<Patient>
{
    public PatientValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty()
            .NotNull()
            .Length(1, 100);

        RuleFor(p => p.CitizenId)
            .NotEmpty()
            .NotNull()
            .Length(1, 20);

        RuleFor(p => p.BirthDate)
            .NotEmpty()
            .NotNull();

        RuleFor(p => p.Gender)
            .NotEmpty()
            .IsInEnum();

        RuleFor(p => p.Nationality)
            .NotEmpty()
            .NotNull()
            .Length(1, 50);

        RuleFor(p => p.PhoneNumber)
            .NotEmpty()
            .NotNull()
            .Matches(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$")
            .WithMessage("Phone number should be between 10 and 15 digits");

        RuleFor(p => p.Email)
            .NotEmpty()
            .NotNull()
            .EmailAddress();

        RuleFor(p => p.Country)
            .NotEmpty()
            .NotNull()
            .Length(1, 50);

        RuleFor(p => p.City)
            .NotEmpty()
            .NotNull()
            .Length(1, 50);

        RuleFor(p => p.Street)
            .NotEmpty()
            .NotNull()
            .Length(1, 100);

        RuleFor(p => p.Address1)
            .NotEmpty()
            .NotNull()
            .Length(1, 100);

        RuleFor(p => p.Address2)
            .Length(1, 100);

        RuleFor(p => p.ContactPerson)
            .NotEmpty()
            .NotNull()
            .Length(1, 100);

        RuleFor(p => p.ContactRelation)
            .NotEmpty()
            .NotNull()
            .Length(1, 50);

        RuleFor(p => p.ContactPhone)
            .NotEmpty()
            .NotNull()
            .Matches(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$")
            .WithMessage("Contact phone number should be between 10 and 15 digits");

        RuleFor(p => p.FirstVisitDate)
            .NotEmpty()
            .NotNull();

        RuleFor(p => p.RecordCreationDate)
            .NotEmpty()
            .NotNull();
    }
}
