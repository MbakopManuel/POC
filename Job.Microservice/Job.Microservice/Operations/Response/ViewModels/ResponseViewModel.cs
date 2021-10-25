using System;
using Job.Microservice.Entities;

namespace Job.Microservice.Operations.Response.ViewModels {

    public class ResponseViewModel : BaseEntity {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public int RequestId { get; set; }
    }

}