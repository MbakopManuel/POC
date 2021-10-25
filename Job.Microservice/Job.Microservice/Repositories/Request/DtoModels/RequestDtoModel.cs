using System;
using Job.Microservice.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job.Microservice.Repositories.Request.DtoModels {
    
    [Table("Requests")]
    public class RequestDtoModel : BaseEntity {
       
        public string Name { get; set; }
        public string Status { get; set; }
    }

}
