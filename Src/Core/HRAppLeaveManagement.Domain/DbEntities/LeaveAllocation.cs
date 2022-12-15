using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRAppLeaveManagement.Domain.DbEntities.Common;

namespace HRAppLeaveManagement.Domain.DbEntities
{
    public class LeaveAllocation:BaseDomainEntity
    {
        

        public int NumberOfDays { get; set; }

  
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
