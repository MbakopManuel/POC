using System;
using Job.Microservice.Entities;
namespace Job.Microservice.Services.Response.DomainModels{

    public class ResponseDomainModel : BaseEntity {
        public string Name { get; set; }
        public string Description { get; set; }
        public int RequestId { get; set; }
    }

}