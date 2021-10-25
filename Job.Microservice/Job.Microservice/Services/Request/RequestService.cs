using System;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Services.Request.DomainModels;
using Job.Microservice.Repositories.Request.DtoModels;
using Job.Microservice.Services.Request;
using Job.Microservice.Repositories.Request;


namespace Job.Microservice.Services.Request {

    public class RequestService : IRequestService {

        private readonly IRequestRepository _requestRepository;
        private readonly IMapper _mapper;
        public RequestService(IRequestRepository RequestRepository, IMapper mapper) {
            _requestRepository = RequestRepository;
            _mapper = mapper;
        }
        

        public async Task<RequestDomainModel> CreateRequestAsync(RequestDomainModel Request)
        {
            var dto = await _requestRepository.Create(_mapper.Map<RequestDtoModel>(Request));
            return _mapper.Map<RequestDomainModel>(dto);
        }

        public async Task<int> DeleteRequestAsync(int id) => await _requestRepository.DeleteAsync(id);

        public async Task<IEnumerable<RequestDomainModel>> GetAllRequestsAsync()
        {
            var requests = await _requestRepository.GetAllAsync();
            return _mapper.Map<List<RequestDomainModel>>(requests);
        }

        public async Task<RequestDomainModel> GetRequestAsync(int id)
        {
            var request = await _requestRepository.GetSingleAsync(id);
            return _mapper.Map<RequestDomainModel>(request);
        }

        public async Task<RequestDomainModel> UpdateRequestAsync(RequestDomainModel Request)
        {
            var dto = await _requestRepository.UpdateAsync(_mapper.Map<RequestDtoModel>(Request));
            return _mapper.Map<RequestDomainModel>(dto);
        }
    }

}