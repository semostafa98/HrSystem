using AutoMapper;
using HR.LeaveManagment.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Application.Features.LeaveAllocation.Requests.Commands;

namespace HR.LeaveManagment.Application.Features.LeaveAllocation.Handlers.Commands
{
    internal class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            this._leaveAllocationRepository = leaveAllocationRepository;
            this._mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<LeaveAllocationClass>(request.LeaveAllocationDto);
            leaveRequest = await _leaveAllocationRepository.Add(leaveRequest);

            return leaveRequest.Id;
        }
    }
}
