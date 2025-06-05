using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LMS.Infrastructure.Repositories
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly LmsDbContext _context;

        public LeaveRepository(LmsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LeaveEntity>> GetleavesAsync()
        {
            return await _context.leaves.ToListAsync();
        }

        public async Task<LeaveEntity> GetLeaveEntityAsync(Guid id)
        {
            var leaveEntity = await _context.leaves.FindAsync(id);

            if (leaveEntity == null)
            {
                throw new ArgumentException("leaveEntity not found.", nameof(id));
            }

            return leaveEntity;
        }

        public async Task<LeaveEntity> UpdateLeaveEntityAsync(Guid id, LeaveEntity leaveEntity)
        {
            if (LeaveEntityExists(id))
            {
                _context.Entry(leaveEntity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            
            return leaveEntity;
        }

        public async Task<LeaveEntity> AddLeaveEntityAsync(LeaveEntity leaveEntity)
        {
            _context.leaves.Add(leaveEntity);
            await _context.SaveChangesAsync();

            return leaveEntity;
        }

        public async Task<bool> DeleteLeaveEntityAsync(Guid id)
        {
            var leaveEntity = await _context.leaves.FindAsync(id);
            if (leaveEntity is not null)
            {
                _context.leaves.Remove(leaveEntity);
                await _context.SaveChangesAsync();
            }

            return false;
        }

        private bool LeaveEntityExists(Guid id)
        {
            return _context.leaves.Any(e => e.LeaveId == id);
        }
    }
}
