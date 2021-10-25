/** Begin Import */

    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Job.Microservice.Repositories.Job.DtoModels;


	//Job.Microservice namespaces importation for DBContext
	using Job.Microservice.Repositories.Request.DtoModels;




	//Job.Microservice namespaces importation for DBContext
	using Job.Microservice.Repositories.Response.DtoModels;



/* End Import */

namespace Job.Microservice.Data
{
    public interface IApplicationDbContext
    {

        /** Begin Interface DBContext Adding */

            DbSet<JobDtoModel> Jobs{ get; set; }


			//Request DBContext application injections
			DbSet<RequestDtoModel> Requests { get; set; }




			//Response DBContext application injections
			DbSet<ResponseDtoModel> Responses { get; set; }



        /** End Interface DBContext Adding */
        Task<int> SaveChanges();
    }
}