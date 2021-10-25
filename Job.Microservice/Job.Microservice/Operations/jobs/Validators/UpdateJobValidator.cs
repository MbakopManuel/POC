using FluentValidation;
using Job.Microservice.Operations.Job.ViewModels;

namespace Job.Microservice.Operations.Job.Validator{
    public class UpdateJobValidator : AbstractValidator<UpdateJobViewModel> {
        public UpdateJobValidator() {

                RuleFor(job => job.Id)
                    .NotEmpty()
                    .NotNull();
                RuleFor(job => job.Name)
                    .NotEmpty()
                    .NotNull();
            
                RuleFor(job => job.City)
                    .NotEmpty()
                    .NotNull();
            
                RuleFor(job => job.Contact)
                    .NotEmpty()
                    .NotNull();
            
                RuleFor(job => job.Email)
                    .NotEmpty()
                    .NotNull();
            
        }


    }
}
