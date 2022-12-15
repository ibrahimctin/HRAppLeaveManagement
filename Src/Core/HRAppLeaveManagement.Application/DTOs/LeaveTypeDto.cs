using HRAppLeaveManagement.Application.DTOs.Common;

namespace HRAppLeaveManagement.Application.DTOs
{
    public class LeaveTypeDto:BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
