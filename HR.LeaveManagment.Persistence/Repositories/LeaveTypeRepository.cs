using HR.LeaveManagment.Application.Persistence.Contracts;
using HR.LeaveManagment.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagmentDbContext _dbContext;
        public LeaveTypeRepository(LeaveManagmentDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LeaveType> GetLeaveTypeWithDetails(int Id)
        {
            return null;

        }

        public async Task<List<LeaveType>> GetLeaveTypeWithDetails()
        {
            return null;
        }
    }
}
