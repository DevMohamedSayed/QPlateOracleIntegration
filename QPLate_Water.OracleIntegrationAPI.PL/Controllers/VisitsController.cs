using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QPLate_Water.OracleIntegrationAPI.BL.Response;
using QPLate_Water.OracleIntegrationAPI.BL.VisitsRepository;
using QPLate_Water.OracleIntegrationAPI.DAL.Dtos.Visits;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;

namespace QPLate_Water.OracleIntegrationAPI.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {
        private readonly IVisitsRepository _VisitsRepository;
        private readonly IMapper _mapper;
        public VisitsController(IVisitsRepository VisitsRepository
                                , IMapper mapper)
        {
            _VisitsRepository = VisitsRepository;
            _mapper = mapper;
        }
        [HttpPost("CreateVisit")]
        public async Task<Response<Visit>> Create(CreateVisitDto createVisitDto)
        {
            return await _VisitsRepository.Create(_mapper.Map<Visit>(createVisitDto));
        }
    }
}
