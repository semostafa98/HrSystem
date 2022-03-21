﻿using HR.LeaveManagment.Application.DTOs.Common;
using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto: BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }


    }
}
