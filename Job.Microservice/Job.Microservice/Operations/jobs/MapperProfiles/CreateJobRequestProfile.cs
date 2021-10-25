using AutoMapper;
using Job.Microservice.Operations.Job.ViewModels;
using Job.Microservice.Services.Job.DomainModels;

namespace Job.Microservice.Operations.Job.MapperProfiles
{
    public class CreateJobRequestProfile : Profile
    {
        public CreateJobRequestProfile()
        {
            CreateMap<CreateJobViewModel, JobDomainModel>().ReverseMap();
        }
    }
}
