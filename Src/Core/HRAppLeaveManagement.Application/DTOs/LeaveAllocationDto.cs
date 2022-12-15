using HRAppLeaveManagement.Application.DTOs.Common;
using HRAppLeaveManagement.Domain.DbEntities;

namespace HRAppLeaveManagement.Application.DTOs
{
    public class LeaveAllocationDto:BaseDto
    {
        public int NumberOfDays { get; set; }


        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
