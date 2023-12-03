using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.Models
{
    public class Visitor
    {
        [Key]

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string NationalId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Visit> Visits{ get; set; }
        public Vehicle Vehicle { get; set; }



    }
}
