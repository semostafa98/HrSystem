using HR.LeaveManagment.Application.DTOs.Common;
using HR.LeaveManagment.Domain.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Domain
{
    public class LeaveAllocationDto : BaseDto
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
