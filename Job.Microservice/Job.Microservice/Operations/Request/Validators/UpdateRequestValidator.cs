using FluentValidation;
using Job.Microservice.Operations.Request.ViewModels;

namespace Job.Microservice.Operations.Request.Validator{
    public class UpdateRequestValidator : AbstractValidator<UpdateRequestViewModel> {
        public UpdateRequestValidator() {

                RuleFor(request => request.Id)
                    .NotEmpty()
                    .NotNull();
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
