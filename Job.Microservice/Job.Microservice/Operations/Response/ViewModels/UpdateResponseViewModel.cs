using System;
using Job.Microservice.Entities;

namespace Job.Microservice.Operations.Response.ViewModels {

    public class UpdateResponseViewModel : BaseEntity {
       
        public string Name { get; set; }
        public string Contact { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }

}