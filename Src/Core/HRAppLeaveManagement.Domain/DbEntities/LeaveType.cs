using HRAppLeaveManagement.Domain.DbEntities.Common;
using System.ComponentModel.DataAnnotations;

namespace HRAppLeaveManagement.Domain.DbEntities
{
    public class LeaveType:BaseDomainEntity
    {
     
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
