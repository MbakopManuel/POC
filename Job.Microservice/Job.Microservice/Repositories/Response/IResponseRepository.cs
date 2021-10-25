using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Repositories.Response.DtoModels;

namespace Job.Microservice.Repositories.Response {

    public interface IResponseRepository{

        Task<IEnumerable<ResponseDtoModel>> GetAllAsync();

        Task<ResponseDtoModel> GetSingleAsync(int id);

        Task<ResponseDtoModel> Create(ResponseDtoModel response);

        Task<ResponseDtoModel> UpdateAsync(ResponseDtoModel response);

        Task<int> DeleteAsync(int id);
        Task<ResponseDtoModel> GetSingleByRequestIdAsync(int id);

    }

}