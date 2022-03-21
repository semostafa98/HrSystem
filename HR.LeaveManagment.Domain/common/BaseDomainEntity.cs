﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Domain.common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }


    }
}
