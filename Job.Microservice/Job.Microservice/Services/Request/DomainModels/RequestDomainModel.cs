using System;
using Job.Microservice.Entities;
namespace Job.Microservice.Services.Request.DomainModels{

    public class RequestDomainModel : BaseEntity {
        public string Name { get; set; }
        public string Status { get; set; }
    }

}