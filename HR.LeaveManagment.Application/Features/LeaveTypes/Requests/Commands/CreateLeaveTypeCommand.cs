using HR.LeaveManagment.Application.DTOs.LeaveType;
using HR.LeaveManagment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand: IRequest<int>
    {
        public CreateLeaveTypeDto LeaveTypeDto { get; set; }

    }
}
