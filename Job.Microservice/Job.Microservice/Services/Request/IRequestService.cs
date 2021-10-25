using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Services.Request.DomainModels;

namespace Job.Microservice.Services.Request {

    public interface IRequestService{


        Task<IEnumerable<RequestDomainModel>> GetAllRequestsAsync();

        Task<RequestDomainModel> GetRequestAsync(int id);

        Task<RequestDomainModel> CreateRequestAsync(RequestDomainModel Request);

        Task<RequestDomainModel> UpdateRequestAsync(RequestDomainModel Request);

        Task<int> DeleteRequestAsync(int id);

    }

}