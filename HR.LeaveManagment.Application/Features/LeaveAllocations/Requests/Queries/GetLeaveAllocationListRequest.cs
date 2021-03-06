using HR.LeaveManagment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {
        public int Id { get; set; }
    }
}
