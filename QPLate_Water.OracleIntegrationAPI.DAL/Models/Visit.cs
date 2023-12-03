using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.Models
{
    public class Visit
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int VisitorId { get; set; }
        public virtual Visitor Visitor { get; set; }
        public string EmployeeNationalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int AccessPathId { get; set; }
    }
}
