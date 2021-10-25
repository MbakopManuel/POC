using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.Microservice.Data;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Job.Microservice.Services.Request;
using Job.Microservice.Services.Request.DomainModels;
using Job.Microservice.Operations.Request.ViewModels;
using Job.Microservice.Operations.Request.Validator;
using AutoMapper;
using System.Diagnostics.Contracts;

namespace Job.Microservice.Operations
{
    [Route("[controller]")]
    [ApiController]
    public class RequestController : BaseController
    {
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;
        public RequestController(
            IMapper mapper,
            IRequestService requestService
        )
        {
            _requestService = requestService;
            _mapper = mapper;
        }


    }
}