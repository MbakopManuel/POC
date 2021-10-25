using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Repositories.Job.DtoModels;

namespace Job.Microservice.Repositories.Job {

    public interface IJobRepository{

        Task<IEnumerable<JobDtoModel>> GetAllAsync();

        Task<JobDtoModel> GetSingleAsync(int id);

        Task<JobDtoModel> Create(JobDtoModel job);

        Task<JobDtoModel> UpdateAsync(JobDtoModel job);

        Task<int> DeleteAsync(int id);

    }

}