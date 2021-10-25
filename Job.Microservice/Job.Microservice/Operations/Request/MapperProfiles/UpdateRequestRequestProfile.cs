using AutoMapper;
using Job.Microservice.Operations.Request.ViewModels;
using Job.Microservice.Services.Request.DomainModels;

namespace Job.Microservice.Operations.Request.MapperProfiles
{
    public class UpdateRequestRequestProfile : Profile
    {
        public UpdateRequestRequestProfile()
        {
            CreateMap<UpdateRequestViewModel, RequestDomainModel>().ReverseMap();
        }
    }
}
