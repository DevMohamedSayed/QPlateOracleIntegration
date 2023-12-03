using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QPLate_Water.OracleIntegrationAPI.BL.GenericRepository;
using QPLate_Water.OracleIntegrationAPI.BL.Response;
using QPLate_Water.OracleIntegrationAPI.BL.UnitOfWork;
using QPLate_Water.OracleIntegrationAPI.DAL.DBContext;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;

namespace QPLate_Water.OracleIntegrationAPI.BL.VehicleRepository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Vehicle> _VehicleRepository;
        public VehicleRepository( ApplicationDBContext context 
                       , IMapper mapper
                       , IUnitOfWork unitOfWork )
        {
            _mapper = mapper;
            _context = context;
            _unitOfWork = unitOfWork;
            _VehicleRepository = _unitOfWork.GetRepository<Vehicle>();
        }

        public async Task<Response<Vehicle>> Create(Vehicle entity)
        {
            return await _VehicleRepository.Create(entity);
        }

        public async Task<Response<Vehicle>> Delete(int id)
        {
            return await _VehicleRepository.Delete(id);
        }

        public async Task<Response<List<Vehicle>>> GetAll()
        {
            return await _VehicleRepository.GetAll();
        }

        public async Task<Response<Vehicle>> GetById(int id)
        {
            return await _VehicleRepository.GetById(id);
        }

        public async Task<Response<Vehicle>> Nullifytag(string TagEpc)
        {
            Vehicle vehicle = await _context.Vehicle.FirstOrDefaultAsync(c => c.TagEpc == TagEpc);
            //return (vehicle == null) ? new hResponse<Vehicle>().responce("Their is no vehicle with this tag", 204, null, true) :
            //    new Response<Vehicle>().responce("Success", 204, vehicle, true);
            if (vehicle == null)
                return new Response<Vehicle>().responce("Their is no vehicle with this tag", 204, null, true);
            else { 
            vehicle.TagEpc = null;
            this._context.SaveChanges();
            return new Response<Vehicle>().responce("Success", 204, vehicle, true);
            }
        }

        public async Task<Response<Vehicle>> Update(Vehicle entity)
        {
            _context.ChangeTracker.Clear();
            return await _VehicleRepository.Update(entity);
        }
    }
}
