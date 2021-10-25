using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Job.Microservice.Repositories.Request.DtoModels;
using Job.Microservice.Data;
using Microsoft.EntityFrameworkCore;

namespace Job.Microservice.Repositories.Request {

    public class RequestRepository : IRequestRepository {
        private readonly IApplicationDbContext _context;
        
        public RequestRepository(
            IApplicationDbContext context
        ){
            _context = context;
        }

        public async Task<RequestDtoModel> Create(RequestDtoModel request)
        {
           await _context.Requests.AddAsync(request);
           await _context.SaveChanges();

           return request;
        }

        public async Task<int> DeleteAsync(int id)
        {
           var dto = _context.Requests.FirstOrDefault(x => x.Id == id);
            _context.Requests.Remove(dto);
            await _context.SaveChanges();

            return id;
        }

        public async Task<IEnumerable<RequestDtoModel>> GetAllAsync()
        {
            var requests = await _context.Requests.ToListAsync();
            
            return requests;
        }

        public async Task<RequestDtoModel> GetSingleAsync(int id)
        {
            var request =  await _context.Requests.FirstOrDefaultAsync(x => x.Id == id);
            return request;
        }

        public async Task<RequestDtoModel> UpdateAsync(RequestDtoModel request)
        {
            Contract.Requires(request != null);
            var dto = await _context.Requests.FirstOrDefaultAsync(x => x.Id == request.Id);
            dto.Status = request.Status;
            await _context.SaveChanges();

            return request;
        }
    }

}
