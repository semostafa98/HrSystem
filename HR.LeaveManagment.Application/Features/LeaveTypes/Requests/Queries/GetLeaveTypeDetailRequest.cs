using HR.LeaveManagment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest: IRequest<LeaveTypeDto>
    {
        public int Id { get; set; } 
    }
}
