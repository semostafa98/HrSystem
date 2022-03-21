using AutoMapper;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();

        }
    }
}
