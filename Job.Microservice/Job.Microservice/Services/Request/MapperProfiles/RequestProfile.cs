using AutoMapper;
using Job.Microservice.Repositories.Request.DtoModels;
using Job.Microservice.Services.Request.DomainModels;

namespace Job.Microservice.Services.Request.MapperProfiles
{
    public class RequestProfile : Profile
    {
        public RequestProfile()
        {
            CreateMap<RequestDomainModel, RequestDtoModel>().ReverseMap();
        }
    }
}
