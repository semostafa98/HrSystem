using HR.LeaveManagment.Application.DTOs.Common;
using HR.LeaveManagment.Domain.common;
using System;
using System.Collections.Generic;
using System.Text;


namespace HR.LeaveManagment.Domain
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
