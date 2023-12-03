using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QPLate_Water.OracleIntegrationAPI.BL.GenericRepository;
using QPLate_Water.OracleIntegrationAPI.BL.Response;
using QPLate_Water.OracleIntegrationAPI.BL.UnitOfWork;
using QPLate_Water.OracleIntegrationAPI.DAL.DBContext;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;

namespace QPLate_Water.OracleIntegrationAPI.BL.AccessPathRepository
{
    public class AccessPathRepository : IAccessPathRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<AccessPath> _AccessPathRepository;
        public AccessPathRepository( ApplicationDBContext context 
                       , IMapper mapper
                       , IUnitOfWork unitOfWork )
        {
            _mapper = mapper;
            _context = context;
            _unitOfWork = unitOfWork;
            _AccessPathRepository = _unitOfWork.GetRepository<AccessPath>();
        }

        public Task<Response<AccessPath>> Create(AccessPath entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<AccessPath>> Delete(int id)
        {
            return await _AccessPathRepository.Delete(id);
        }

        public async Task<Response<List<AccessPath>>> GetAll()
        {
          return   await _AccessPathRepository.GetAll();
        }

        public  Task<Response<AccessPath>> GetById(int id)
        {
           return _AccessPathRepository.GetById(id);
        }

        public async Task<Response<AccessPath>> Update(AccessPath entity)
        {
            return await _AccessPathRepository.Update(entity);
        }
    }
}
