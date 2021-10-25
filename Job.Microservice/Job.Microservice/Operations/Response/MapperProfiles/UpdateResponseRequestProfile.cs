using AutoMapper;
using Job.Microservice.Operations.Response.ViewModels;
using Job.Microservice.Services.Response.DomainModels;

namespace Job.Microservice.Operations.Response.MapperProfiles
{
    public class UpdateResponseRequestProfile : Profile
    {
        public UpdateResponseRequestProfile()
        {
            CreateMap<UpdateResponseViewModel, ResponseDomainModel>().ReverseMap();
        }
    }
}
