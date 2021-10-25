/** Begin Import */

    using Job.Microservice.Repositories.Job.DtoModels;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


	//Job.Microservice namespaces importation for DBContext
	using Job.Microservice.Repositories.Request.DtoModels;




	//Job.Microservice namespaces importation for DBContext
	using Job.Microservice.Repositories.Response.DtoModels;



/* End Import */

namespace Job.Microservice.Data
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /** Begin DBContext Adding */

            DbSet<JobDtoModel> IApplicationDbContext.Jobs { get; set; }


	//Request DBContext application injections
			DbSet<RequestDtoModel> IApplicationDbContext.Requests { get; set; }




	//Response DBContext application injections
			DbSet<ResponseDtoModel> IApplicationDbContext.Responses { get; set; }


        
        /** End DBContext Adding */

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}