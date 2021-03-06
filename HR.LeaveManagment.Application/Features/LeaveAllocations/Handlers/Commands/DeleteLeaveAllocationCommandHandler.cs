using AutoMapper;
using HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Commands;
using HR.LeaveManagment.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            this._leaveAllocationRepository = leaveAllocationRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.Id);
            await _leaveAllocationRepository.Delete(leaveAllocation);
            return Unit.Value;
        }
    }
}
