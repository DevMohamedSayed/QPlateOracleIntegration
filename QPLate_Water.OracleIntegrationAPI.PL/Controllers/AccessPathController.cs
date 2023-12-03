using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QPLate_Water.OracleIntegrationAPI.BL.AccessPathRepository;
using QPLate_Water.OracleIntegrationAPI.BL.Response;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;

namespace QPLate_Water.OracleIntegrationAPI.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessPathController : ControllerBase
    {
        private readonly IAccessPathRepository _AccessPathRepository;
        private readonly IMapper _mapper;
        public AccessPathController(IAccessPathRepository accessPathRepository
                                , IMapper mapper)
        {
            _AccessPathRepository = accessPathRepository;
            _mapper = mapper;
        }
        [HttpGet("accessPaths")]
        public async Task<Response<List<AccessPath>>> Get()
        {
            return await _AccessPathRepository.GetAll();
        }
    }
}
