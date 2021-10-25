using AutoMapper;
using Job.Microservice.Operations.Request.ViewModels;
using Job.Microservice.Services.Request.DomainModels;

namespace Job.Microservice.Operations.Request.MapperProfiles
{
    public class CreateRequestRequestProfile : Profile
    {
        public CreateRequestRequestProfile()
        {
            CreateMap<CreateRequestViewModel, RequestDomainModel>().ReverseMap();
        }
    }
}
