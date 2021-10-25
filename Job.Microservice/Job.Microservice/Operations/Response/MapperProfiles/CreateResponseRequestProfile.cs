using AutoMapper;
using Job.Microservice.Operations.Response.ViewModels;
using Job.Microservice.Services.Response.DomainModels;

namespace Job.Microservice.Operations.Response.MapperProfiles
{
    public class CreateResponseRequestProfile : Profile
    {
        public CreateResponseRequestProfile()
        {
            CreateMap<CreateResponseViewModel, ResponseDomainModel>().ReverseMap();
        }
    }
}
