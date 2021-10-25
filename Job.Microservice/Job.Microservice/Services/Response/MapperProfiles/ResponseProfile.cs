using AutoMapper;
using Job.Microservice.Repositories.Response.DtoModels;
using Job.Microservice.Services.Response.DomainModels;

namespace Job.Microservice.Services.Response.MapperProfiles
{
    public class ResponseProfile : Profile
    {
        public ResponseProfile()
        {
            CreateMap<ResponseDomainModel, ResponseDtoModel>().ReverseMap();
        }
    }
}
