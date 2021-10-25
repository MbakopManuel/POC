using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Job.Microservice.Repositories.Response.DtoModels;
using Job.Microservice.Data;
using Microsoft.EntityFrameworkCore;

namespace Job.Microservice.Repositories.Response {

    public class ResponseRepository : IResponseRepository {
        private readonly IApplicationDbContext _context;
        
        public ResponseRepository(
            IApplicationDbContext context
        ){
            _context = context;
        }

        public async Task<ResponseDtoModel> Create(ResponseDtoModel resp)
        {
           var res = await _context.Responses.AddAsync(resp);
           var saved = await _context.SaveChanges();

           return resp;
        }

        public async Task<int> DeleteAsync(int id)
        {
           var dto = _context.Responses.FirstOrDefault(x => x.Id == id);
            _context.Responses.Remove(dto);
            await _context.SaveChanges();

            return id;
        }

        public async Task<IEnumerable<ResponseDtoModel>> GetAllAsync()
        {
            var responses = await _context.Responses.ToListAsync();
            
            return responses;
        }

        public async Task<ResponseDtoModel> GetSingleAsync(int id)
        {
            var response =  await _context.Responses.FirstOrDefaultAsync(x => x.Id == id);
            return response;
        }

        public async Task<ResponseDtoModel> GetSingleByRequestIdAsync(int id)
        {
            var response =  await _context.Responses.FirstOrDefaultAsync(x => x.RequestId == id);
            return response;
        }

        public async Task<ResponseDtoModel> UpdateAsync(ResponseDtoModel response)
        {
            Contract.Requires(response != null);
            var dto = await _context.Responses.FirstOrDefaultAsync(x => x.Id == response.Id);
            dto = response;
            await _context.SaveChanges();

            return response;
        }
    }

}
