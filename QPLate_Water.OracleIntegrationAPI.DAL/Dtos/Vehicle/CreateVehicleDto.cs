using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.Dtos.Vehicle
{
    public class CreateVehicleDto
    {
        public string PlateNumber { get; set; }
        public string TagEpc { get; set; }
        public int TypeId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int? EmployeeId { get; set; }
        public int? VisitorId { get; set; }
    }

}
