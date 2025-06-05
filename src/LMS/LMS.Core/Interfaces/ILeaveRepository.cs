using LMS.Core.Entities;

namespace LMS.Core.Interfaces
{
    public interface ILeaveRepository
    {
        Task<IEnumerable<LeaveEntity>> GetleavesAsync();
        Task<LeaveEntity> GetLeaveEntityAsync(Guid id);
        Task<LeaveEntity> UpdateLeaveEntityAsync(Guid id, LeaveEntity leaveEntity);
        Task<LeaveEntity> AddLeaveEntityAsync(LeaveEntity leaveEntity);
        Task<bool> DeleteLeaveEntityAsync(Guid id);
    }
}
