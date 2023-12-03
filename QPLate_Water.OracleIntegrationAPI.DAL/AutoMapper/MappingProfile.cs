using AutoMapper;
using Microsoft.AspNetCore.Identity;
using QPLate_Water.OracleIntegrationAPI.DAL.Dtos;
using QPLate_Water.OracleIntegrationAPI.DAL.Dtos.Vehicle;
using QPLate_Water.OracleIntegrationAPI.DAL.Dtos.Visits;
using QPLate_Water.OracleIntegrationAPI.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPLate_Water.OracleIntegrationAPI.DAL.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IdentityUser, CreateUserDto>().ReverseMap();
            CreateMap<IdentityUser, UpdateUserDto>().ReverseMap();
            CreateMap<IdentityUser, LoginUser>().ReverseMap();
            CreateMap<Vehicle, CreateVehicleDto>().ReverseMap();
            CreateMap<Visit, CreateVisitDto>().ReverseMap();
        }
    }
}
