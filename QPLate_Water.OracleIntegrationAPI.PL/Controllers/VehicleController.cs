using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QPLate_Water.OracleIntegrationAPI.BL.Response;
using QPLate_Water.OracleIntegrationAPI.BL.VehicleRepository;
using QPLate_Water.OracleIntegrationAPI.DAL.Dtos.Vehicle;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;

namespace QPLate_Water.OracleIntegrationAPI.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _vehicle;
        private readonly IMapper _mapper;
        public VehicleController(IVehicleRepository vehicle
                                , IMapper mapper)
        {
            _vehicle = vehicle;
            _mapper = mapper;
        }
        [HttpPost("CreateVehicle")]
        public async Task<Response<Vehicle>> Create(CreateVehicleDto entity)
        {
            return await _vehicle.Create(_mapper.Map<Vehicle>(entity));
        }

        [HttpPost("Nullifytag")]
        public async Task<Response<Vehicle>> Nullifytag(string TagEpc)
        {
            return await _vehicle.Nullifytag(TagEpc);
        }

        
      

    }
}
