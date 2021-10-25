using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.Microservice.Data;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Job.Microservice.Services.Job;
using Job.Microservice.Services.Job.DomainModels;
using Job.Microservice.Operations.Job.ViewModels;
using Job.Microservice.Operations.Job.Validator;
using AutoMapper;
using System.Diagnostics.Contracts;
using Job.Microservice.Services.Request;
using Job.Microservice.Services.Response;
using Job.Microservice.Services.Request.DomainModels;
using Job.Microservice.Operations.Response.ViewModels;
using Job.Microservice.Services.Response.DomainModels;
using Microsoft.Extensions.DependencyInjection;

namespace Job.Microservice.Operations
{
    [Route("[controller]")]
    [ApiController]
    public class JobController : BaseController
    {
        private readonly IJobService _jobService;
        private readonly IRequestService _requestService;
        private readonly IResponseService _responseService;
        private readonly IMapper _mapper;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        public JobController(
            IMapper mapper,
            IJobService jobService,
            IRequestService requestService,
            IResponseService responseService,
            IServiceScopeFactory serviceScopeFactory
        )
        {
            _jobService = jobService;
            _requestService = requestService;
            _responseService = responseService;
            _serviceScopeFactory = serviceScopeFactory;
            _mapper = mapper;
        }


        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        // [ProducesResponseType(StatusCodes.Status500InternalServerError)]    
        // [ProducesResponseType(StatusCodes.Status400BadRequest)]   
        // [HttpPost]
        // public async Task<ActionResult<JobViewModel>> Create([FromBody] CreateJobViewModel viewModel)
        // {

        //    try
        //     {
        //         var validator = new CreateJobValidator();

        //         var validate = validator.Validate(viewModel);

        //         if(!validate.IsValid){
        //             return HandleErrorResponse(HttpStatusCode.BadRequest, validate.ToString());
        //         }

        //         var job = _mapper.Map<JobDomainModel>(viewModel);

        //         // create new job
        //         var createdJob = await _jobService.CreateJobAsync(job);

        //         // prepare response
        //         var response = _mapper.Map<JobViewModel>(createdJob);

        //         return HandleCreatedResponse(response);
        //     }
        //     catch (Exception ex)
        //     {
        //         return HandleErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //     }
        // }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]    
        [ProducesResponseType(StatusCodes.Status400BadRequest)]   
        [HttpGet("advancesync")]
        public async Task<ActionResult<int>> GetAdvanceSync()
        {
           try
            {
               RequestDomainModel request = new RequestDomainModel(){
                   Name = "Request Name",
                   Status = "pending"
               };
               var req = await _requestService.CreateRequestAsync(request);
               var id = req.Id;
              
               var t = Task.Run(
                   async () => {
                       await _jobService.CreateJobAsync((int)id, _serviceScopeFactory);
                   }
               );
               return HandleSuccessResponse(req.Id);

            }
            catch (Exception ex)
            {
                return HandleErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]    
        [ProducesResponseType(StatusCodes.Status400BadRequest)]   
        [HttpGet("advancesync/status/reqId/{id}")]
        public async Task<ActionResult<object>> GetById(int id)
        {
           try
            {
                var req =await _requestService.GetRequestAsync(id);
                if(req == null){ 
                    return HandleErrorResponse(HttpStatusCode.NotFound, $"Request with id {id} not found");
                }
                if(req.Status == "finished"){
                    return HandleSuccessResponse(new{ Ready = true});
                }
                 return HandleSuccessResponse(new{ Ready = false});
            }
            catch (Exception ex)
            {
                return HandleErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]    
        [ProducesResponseType(StatusCodes.Status400BadRequest)]   
        [HttpGet("advancesync/result/reqId/{id}")]
        public async Task<ActionResult<ResponseViewModel>> ResponseWithId(int id)
        {
           try
            {
                var req =await _requestService.GetRequestAsync(id);
                if(req == null){ 
                    return HandleErrorResponse(HttpStatusCode.NotFound, $"Request with id {id} not found");
                }
                if(req.Status == "finished"){
                    var res =await _responseService.GetResponseByRequestIdAsync(id);
                    if(res == null){ 
                        return HandleErrorResponse(HttpStatusCode.NotFound, $"response with request id {id} not found");
                    }
                    return HandleSuccessResponse(_mapper.Map<ResponseViewModel>(res));
                }
                 return HandleSuccessResponse(new{ Ready = false});
            }
            catch (Exception ex)
            {
                return HandleErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}