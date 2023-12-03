using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string? TagEpc { get; set; }
        public int TypeId { get; set; }
        public virtual VehicleType Type { get; set; }
        public int BrandId { get; set; }
        public virtual VehicleBrand Brand { get; set; }
        public int ColorId { get; set; }
        public virtual VehicleColor Color { get; set; }
        public int? VisitorId { get; set; }
        public virtual Employee Employee { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Visitor Visitor { get; set; }

    }
}
