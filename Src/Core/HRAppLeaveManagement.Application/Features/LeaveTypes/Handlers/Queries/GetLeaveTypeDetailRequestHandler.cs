using AutoMapper;
using HRAppLeaveManagement.Application.DTOs;
using HRAppLeaveManagement.Application.Features.LeaveTypes.Requests;
using HRAppLeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HRAppLeaveManagement.Application.Persistence.Contracts;
using MediatR;

namespace HRAppLeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var data = await _leaveTypeRepository.GetAsync(request.Id);

            return _mapper.Map<LeaveTypeDto>(data); 
        }
    }
}
