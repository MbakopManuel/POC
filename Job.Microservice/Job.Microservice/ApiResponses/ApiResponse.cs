using System.Collections.Generic;

namespace Job.Microservice.Operations.ApiResponses
{
    public class ApiResponse
    {
        public object Data { get; set; }

        public IEnumerable<ApiError> Errors { get; set; }
    }
}
