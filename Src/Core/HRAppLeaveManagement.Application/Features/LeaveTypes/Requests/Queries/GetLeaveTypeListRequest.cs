using HRAppLeaveManagement.Application.DTOs;
using MediatR;

namespace HRAppLeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
    {
    }
}
