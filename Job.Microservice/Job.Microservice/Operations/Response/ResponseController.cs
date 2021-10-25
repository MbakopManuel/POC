using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Job.Microservice.Data;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Job.Microservice.Services.Response;
using Job.Microservice.Services.Response.DomainModels;
using Job.Microservice.Operations.Response.ViewModels;
using Job.Microservice.Operations.Response.Validator;
using AutoMapper;
using System.Diagnostics.Contracts;

namespace Job.Microservice.Operations
{
    [Route("[controller]")]
    [ApiController]
    public class ResponseController : BaseController
    {
        private readonly IResponseService _responseService;
        private readonly IMapper _mapper;
        public ResponseController(
            IMapper mapper,
            IResponseService responseService
        )
        {
            _responseService = responseService;
            _mapper = mapper;
        }

    }
}