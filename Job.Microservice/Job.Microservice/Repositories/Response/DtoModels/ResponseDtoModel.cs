using System;
using Job.Microservice.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Job.Microservice.Repositories.Response.DtoModels {
    
    [Table("Responses")]
    public class ResponseDtoModel : BaseEntity {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public int RequestId { get; set; }
    }

}
