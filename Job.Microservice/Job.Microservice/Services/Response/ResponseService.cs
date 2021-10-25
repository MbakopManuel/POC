using System;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Job.Microservice.Services.Response.DomainModels;
using Job.Microservice.Repositories.Response.DtoModels;
using Job.Microservice.Services.Response;
using Job.Microservice.Repositories.Response;


namespace Job.Microservice.Services.Response {

    public class ResponseService : IResponseService {

        private readonly IResponseRepository _responseRepository;
        private readonly IMapper _mapper;
        public ResponseService(IResponseRepository ResponseRepository, IMapper mapper) {
            _responseRepository = ResponseRepository;
            _mapper = mapper;
        }
        

        public async Task<ResponseDomainModel> CreateResponseAsync(ResponseDomainModel Response)
        {
            var dto = await _responseRepository.Create(_mapper.Map<ResponseDtoModel>(Response));
            return _mapper.Map<ResponseDomainModel>(dto);
        }

        public async Task<int> DeleteResponseAsync(int id) => await _responseRepository.DeleteAsync(id);

        public async Task<IEnumerable<ResponseDomainModel>> GetAllResponsesAsync()
        {
            var responses = await _responseRepository.GetAllAsync();
            return _mapper.Map<List<ResponseDomainModel>>(responses);
        }

        public async Task<ResponseDomainModel> GetResponseAsync(int id)
        {
            var response = await _responseRepository.GetSingleAsync(id);
            return _mapper.Map<ResponseDomainModel>(response);
        }

        public async Task<ResponseDomainModel> GetResponseByRequestIdAsync(int id)
        {
            var response = await _responseRepository.GetSingleByRequestIdAsync(id);
            return _mapper.Map<ResponseDomainModel>(response);
        }

        public async Task<ResponseDomainModel> UpdateResponseAsync(ResponseDomainModel Response)
        {
            var dto = await _responseRepository.UpdateAsync(_mapper.Map<ResponseDtoModel>(Response));
            return _mapper.Map<ResponseDomainModel>(dto);
        }
    }

}