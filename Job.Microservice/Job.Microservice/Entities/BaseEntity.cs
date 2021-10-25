using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job.Microservice.Entities
{
    public abstract class BaseEntity
    {
        public int? Id { get; set; }
        
        public int? CreatedAt { get; set;}
        
        public int? UpdatedAt { get; set;}
        
        public int? DeletedAt { get; set;}
    }
}
