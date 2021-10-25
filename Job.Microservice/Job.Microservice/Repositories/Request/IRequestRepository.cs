using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Repositories.Request.DtoModels;

namespace Job.Microservice.Repositories.Request {

    public interface IRequestRepository{

        Task<IEnumerable<RequestDtoModel>> GetAllAsync();

        Task<RequestDtoModel> GetSingleAsync(int id);

        Task<RequestDtoModel> Create(RequestDtoModel request);

        Task<RequestDtoModel> UpdateAsync(RequestDtoModel request);

        Task<int> DeleteAsync(int id);

    }

}