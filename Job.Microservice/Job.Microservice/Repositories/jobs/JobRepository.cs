using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Job.Microservice.Repositories.Job.DtoModels;
using Job.Microservice.Data;
using Microsoft.EntityFrameworkCore;

namespace Job.Microservice.Repositories.Job {

    public class JobRepository : IJobRepository {
        private readonly IApplicationDbContext _context;
        
        public JobRepository(
            IApplicationDbContext context
        ){
            _context = context;
        }

        public async Task<JobDtoModel> Create(JobDtoModel job)
        {
           await _context.Jobs.AddAsync(job);
           await _context.SaveChanges();

           return job;
        }

        public async Task<int> DeleteAsync(int id)
        {
           var dto = _context.Jobs.FirstOrDefault(x => x.Id == id);
            _context.Jobs.Remove(dto);
            await _context.SaveChanges();

            return id;
        }

        public async Task<IEnumerable<JobDtoModel>> GetAllAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            
            return jobs;
        }

        public async Task<JobDtoModel> GetSingleAsync(int id)
        {
            var job =  await _context.Jobs.FirstOrDefaultAsync(x => x.Id == id);
            return job;
        }

        public async Task<JobDtoModel> UpdateAsync(JobDtoModel job)
        {
            Contract.Requires(job != null);
            var dto = await _context.Jobs.FirstOrDefaultAsync(x => x.Id == job.Id);
            dto = job;
            await _context.SaveChanges();

            return job;
        }
    }

}
