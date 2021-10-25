using FluentValidation;
using Job.Microservice.Operations.Response.ViewModels;

namespace Job.Microservice.Operations.Response.Validator{
    public class CreateResponseValidator : AbstractValidator<CreateResponseViewModel> {
        public CreateResponseValidator() {

            RuleFor(response => response.Name)
                    .NotEmpty()
                    .NotNull();
            
            RuleFor(response => response.City)
                    .NotEmpty()
                    .NotNull();
            
            RuleFor(response => response.Contact)
                    .NotEmpty()
                    .NotNull();
            
            RuleFor(response => response.Email)
                    .NotEmpty()
                    .NotNull();
            
        }


    }
}
