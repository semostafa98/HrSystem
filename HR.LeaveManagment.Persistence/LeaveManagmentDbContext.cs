using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Domain.common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Persistence
{
    public class LeaveManagmentDbContext: DbContext
    {
        public LeaveManagmentDbContext(DbContextOptions<LeaveManagmentDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveManagmentDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync( CancellationToken cancellationToken = default)
        {
            foreach (var entity in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entity.Entity.LastModifiedDate = DateTime.UtcNow;

                if(entity.State == EntityState.Added)
                {
                    entity.Entity.DateCreated = DateTime.UtcNow;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocationClass> LeaveAllocations { get; set; }

    }
}
