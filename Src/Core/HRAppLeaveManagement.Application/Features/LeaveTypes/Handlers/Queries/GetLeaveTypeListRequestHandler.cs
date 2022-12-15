using AutoMapper;
using HRAppLeaveManagement.Application.DTOs;
using HRAppLeaveManagement.Application.Features.LeaveTypes.Requests;
using HRAppLeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HRAppLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRAppLeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var data = await _leaveTypeRepository.GetAllAsync();

            return _mapper.Map<List<LeaveTypeDto>>(data);
        }
    }
}
