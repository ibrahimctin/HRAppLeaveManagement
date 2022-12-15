using AutoMapper;
using HRAppLeaveManagement.Application.DTOs;
using HRAppLeaveManagement.Application.DTOs.LeaveRequest;
using HRAppLeaveManagement.Domain.DbEntities;

namespace HRAppLeaveManagement.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        }
    }
}
