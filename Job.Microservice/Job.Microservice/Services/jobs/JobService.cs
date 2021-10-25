using System;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Services.Job.DomainModels;
using Job.Microservice.Repositories.Job.DtoModels;
using Job.Microservice.Services.Job;
using Job.Microservice.Repositories.Job;
using Job.Microservice.Repositories.Response;
using Job.Microservice.Repositories.Response.DtoModels;
using Job.Microservice.Repositories.Request;
using Microsoft.Extensions.DependencyInjection;
using Job.Microservice.Data;

namespace Job.Microservice.Services.Job {

    public class JobService : IJobService {

        private readonly IJobRepository _jobRepository;
        private readonly IResponseRepository _responseRepository;
        private readonly IRequestRepository _requestRepository;
        private readonly IMapper _mapper;
        public JobService(IJobRepository JobRepository,IResponseRepository responseRepository,IRequestRepository requestRepository, IMapper mapper) {
            _jobRepository = JobRepository;
            _responseRepository = responseRepository;
            _requestRepository = requestRepository;
            _mapper = mapper;
        }
        

        public async Task CreateJobAsync(int requestId, IServiceScopeFactory serviceScopeFactory)
        {
            await Task.Delay(35000);
            ResponseDtoModel response = new ResponseDtoModel(){
                Name = "Response Name",
                Description = "Response description",
                RequestId = requestId
            };
            using (var scope = serviceScopeFactory.CreateScope())
            {
                var _context = scope.ServiceProvider.GetService<IApplicationDbContext>();
                var res = await _context.Responses.AddAsync(response);
                var saved = await _context.SaveChanges();

                var req  = await _context.Requests.FindAsync(requestId);
                req.Status = "finished";
                await _context.SaveChanges();
                Console.WriteLine("request updated");
            }
            
            return;
        }

        public async Task<int> DeleteJobAsync(int id) => await _jobRepository.DeleteAsync(id);

        public async Task<IEnumerable<JobDomainModel>> GetAllJobsAsync()
        {
            var jobs = await _jobRepository.GetAllAsync();
            return _mapper.Map<List<JobDomainModel>>(jobs);
        }

        public async Task<JobDomainModel> GetJobAsync(int id)
        {
            var job = await _jobRepository.GetSingleAsync(id);
            return _mapper.Map<JobDomainModel>(job);
        }

        public async Task<JobDomainModel> UpdateJobAsync(JobDomainModel Job)
        {
            var dto = await _jobRepository.UpdateAsync(_mapper.Map<JobDtoModel>(Job));
            return _mapper.Map<JobDomainModel>(dto);
        }
    }

}