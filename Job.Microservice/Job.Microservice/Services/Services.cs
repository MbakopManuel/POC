/** 
    This file is the file that make importations, injections dependancies, and profiles adding

 */

/** Begin Import */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection.Extensions;
    using AutoMapper;
    using Microsoft.AspNetCore.Hosting;
    using Job.Microservice.Data;

    using Job.Microservice.Repositories.Job;
    using Job.Microservice.Services.Job;
    using Job.Microservice.Operations.Job.MapperProfiles;
    using Job.Microservice.Services.Job.MapperProfiles;


	//Job.Microservice namespaces importation
	using Job.Microservice.Repositories.Request;
	using Job.Microservice.Services.Request;
	using Job.Microservice.Operations.Request.MapperProfiles;
	using Job.Microservice.Services.Request.MapperProfiles;




	//Job.Microservice namespaces importation
	using Job.Microservice.Repositories.Response;
	using Job.Microservice.Services.Response;
	using Job.Microservice.Operations.Response.MapperProfiles;
	using Job.Microservice.Services.Response.MapperProfiles;



/* End Import */


namespace Job.Microservice.Services {


    public class Service{

        private readonly IServiceCollection _services;
        public Service(IServiceCollection services){
            _services = services;
           
        }

        public Service(){}

        public void addService(){
             /** Begin Injection  */
            
                // _services.AddTransient<IStartupFilter, DBContextMigration<ApplicationDbContext>>();
                
                _services.TryAddScoped<IJobRepository, JobRepository>();
                _services.TryAddTransient<IJobService, JobService>();


				//Request dependency injections
				_services.TryAddScoped<IRequestRepository, RequestRepository>();
				_services.TryAddTransient<IRequestService, RequestService>();




				//Response dependency injections
				_services.TryAddScoped<IResponseRepository, ResponseRepository>();
				_services.TryAddTransient<IResponseService, ResponseService>();


            
            /** End Injection */
          
        }

        public IEnumerable<Profile> addProfile(){
            var profiles = new Profile[] { 

                /** Begin Adding Profiles */

                    new JobProfile(),
                    new JobResponseProfile(),
                    new CreateJobRequestProfile(),
                    new UpdateJobRequestProfile(),


					//Request adding profiles
					new RequestProfile(),
					new RequestResponseProfile(),
					new CreateRequestRequestProfile(),
					new UpdateRequestRequestProfile(),




					//Response adding profiles
					new ResponseProfile(),
					new ResponseResponseProfile(),
					new CreateResponseRequestProfile(),
					new UpdateResponseRequestProfile(),



                /** End Adding Profiles */
                
             };

             return profiles;
        }
        

    }

}