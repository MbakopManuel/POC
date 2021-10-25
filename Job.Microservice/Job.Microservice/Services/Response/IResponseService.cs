using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Services.Response.DomainModels;

namespace Job.Microservice.Services.Response {

    public interface IResponseService{


        Task<IEnumerable<ResponseDomainModel>> GetAllResponsesAsync();

        Task<ResponseDomainModel> GetResponseAsync(int id);

        Task<ResponseDomainModel> CreateResponseAsync(ResponseDomainModel Response);

        Task<ResponseDomainModel> UpdateResponseAsync(ResponseDomainModel Response);

        Task<int> DeleteResponseAsync(int id);
        
        Task<ResponseDomainModel> GetResponseByRequestIdAsync(int id);

    }

}