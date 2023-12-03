using AutoMapper;
using QPLate_Water.OracleIntegrationAPI.BL.GenericRepository;
using QPLate_Water.OracleIntegrationAPI.BL.Response;
using QPLate_Water.OracleIntegrationAPI.BL.UnitOfWork;
using QPLate_Water.OracleIntegrationAPI.DAL.DBContext;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.BL.VisitsRepository
{
    public class VisitsRepository: IVisitsRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Visit> _VisitRepository;
        public VisitsRepository(ApplicationDBContext context
                       , IMapper mapper
                       , IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _context = context;
            _unitOfWork = unitOfWork;
            _VisitRepository = _unitOfWork.GetRepository<Visit>();
        }

        public async Task<Response<Visit>> Create(Visit entity)
        {
            return await _VisitRepository.Create(entity);
        }

        public async Task<Response<Visit>> Delete(int id)
        {
            return await _VisitRepository.Delete(id);
        }

        public async Task<Response<List<Visit>>> GetAll()
        {
            return await _VisitRepository.GetAll();
        }

        public async Task<Response<Visit>> GetById(int id)
        {
            return await _VisitRepository.GetById(id);
        }


        public async Task<Response<Visit>> Update(Visit visit)
        {
            _context.ChangeTracker.Clear();
            return await _VisitRepository.Update(visit);
        }

    }
}
