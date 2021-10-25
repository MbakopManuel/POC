using AutoMapper;
using Job.Microservice.Operations.Response.ViewModels;
using Job.Microservice.Services.Response.DomainModels;

namespace Job.Microservice.Operations.Response.MapperProfiles
{
    public class ResponseResponseProfile : Profile
    {
        public ResponseResponseProfile()
        {
            CreateMap<ResponseViewModel, ResponseDomainModel>().ReverseMap();
        }
    }
}
