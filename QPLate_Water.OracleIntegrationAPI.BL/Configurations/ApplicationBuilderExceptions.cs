using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.Configurations
{
    public static class ApplicationBuilderExceptions
    {
        public static IApplicationBuilder AddGlobalErrorHandler(this IApplicationBuilder applicationBuilder) => applicationBuilder.UseMiddleware<GlobalExceptionHandlingMiddleware>();  
    }
}
