using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.Configuration
{
    public class UnAuthenticatedException : Exception
    {
        public UnAuthenticatedException(string msg) : base(msg) { }
    }
}
