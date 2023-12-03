using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.Dtos.Visits
{
    public class CreateVisitDto
    {
        public string Description { get; set; }
        public int VisitorId { get; set; }
        public string EmployeeNationalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int AccessPathId { get; set; }
    }
}
