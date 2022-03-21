using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    public interface  ILeaveAllocationRepository : IGenericRepository<LeaveAllocationClass>
    {
        Task<LeaveAllocationClass> GetLeaveAllocationWithDetails(int Id);
        Task<List<LeaveAllocationClass>> GetLeaveAllocationWithDetails();

    }
}
