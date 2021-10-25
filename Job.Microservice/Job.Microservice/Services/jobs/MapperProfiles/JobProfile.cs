using AutoMapper;
using Job.Microservice.Repositories.Job.DtoModels;
using Job.Microservice.Services.Job.DomainModels;

namespace Job.Microservice.Services.Job.MapperProfiles
{
    public class JobProfile : Profile
    {
        public JobProfile()
        {
            CreateMap<JobDomainModel, JobDtoModel>().ReverseMap();
        }
    }
}
