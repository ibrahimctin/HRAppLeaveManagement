using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using HRAppLeaveManagement.Domain.DbEntities.Common;

namespace HRAppLeaveManagement.Domain.DbEntities
{
    public class LeaveRequest:BaseDomainEntity
    {
       
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        [ForeignKey("ApprovedById")]
        public string ApprovedById { get; set; }
    }
}
