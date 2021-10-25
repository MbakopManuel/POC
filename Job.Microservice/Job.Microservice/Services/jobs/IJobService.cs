using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Services.Job.DomainModels;
using Microsoft.Extensions.DependencyInjection;

namespace Job.Microservice.Services.Job {

    public interface IJobService{


        Task<IEnumerable<JobDomainModel>> GetAllJobsAsync();

        Task<JobDomainModel> GetJobAsync(int id);

        Task CreateJobAsync(int requestId, IServiceScopeFactory serviceScopeFactory);

        Task<JobDomainModel> UpdateJobAsync(JobDomainModel Job);

        Task<int> DeleteJobAsync(int id);

    }

}