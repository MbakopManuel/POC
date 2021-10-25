using FluentValidation;
using Job.Microservice.Operations.Request.ViewModels;

namespace Job.Microservice.Operations.Request.Validator{
    public class CreateRequestValidator : AbstractValidator<CreateRequestViewModel> {
        public CreateRequestValidator() {

            RuleFor(request => request.Name)
                    .NotEmpty()
                    .NotNull();
            
            RuleFor(request => request.City)
                    .NotEmpty()
                    .NotNull();
            
            RuleFor(request => request.Contact)
                    .NotEmpty()
                    .NotNull();
            
            RuleFor(request => request.Email)
                    .NotEmpty()
                    .NotNull();
            
        }


    }
}
