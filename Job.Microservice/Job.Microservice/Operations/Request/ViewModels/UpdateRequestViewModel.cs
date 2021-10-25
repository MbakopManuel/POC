using System;
using Job.Microservice.Entities;

namespace Job.Microservice.Operations.Request.ViewModels {

    public class UpdateRequestViewModel : BaseEntity {
       
        public string Name { get; set; }
        public string Contact { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }

}