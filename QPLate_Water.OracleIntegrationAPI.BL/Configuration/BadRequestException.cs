using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.Configuration
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string msg) : base(msg) { }
        
    }
}
