using LMS.Core.Entities;
using LMS.Core.Interfaces;
using MediatR;

namespace LMS.Application.Commands
{

    public class UpdateLeaveCommand(Guid leaveId, LeaveEntity leaveEntity) : IRequest<LeaveEntity> 
    {
        public Guid LeaveId { get; } = leaveId;
        public LeaveEntity LeaveEntity { get; } = leaveEntity;
    }
    public class UpdateLeaveCommandHandler(ILeaveRepository leaveRepository) : IRequestHandler<UpdateLeaveCommand, LeaveEntity>
    {
        public async Task<LeaveEntity> Handle(UpdateLeaveCommand request, CancellationToken cancellationToken)
        {
            var leaveId = request.LeaveId;
            var leaveEntity = request.LeaveEntity;
            return await leaveRepository.UpdateLeaveEntityAsync(leaveId, leaveEntity);
        }
    }
}
 