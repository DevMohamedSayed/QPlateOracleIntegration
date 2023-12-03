using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.Models
{
    public class Employee
    {
        public int Id{ get; set; }
        public string NameEn { get; set; }
        public int NameAr { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int IdentityType { get; set; }
        public virtual Company Company {  get; set; }
        public int AccessPathId { get; set; }
        public bool IsContractor { get; set; }
        public bool IsDirectEmployee { get; set; }

    }
}
