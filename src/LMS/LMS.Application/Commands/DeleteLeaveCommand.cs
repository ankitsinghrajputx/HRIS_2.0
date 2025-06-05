using LMS.Core.Entities;
using LMS.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Commands
{
    public record DeleteLeaveCommand(Guid leaveId) : IRequest<bool> 
    {
        public Guid LeaveId { get; } = leaveId;
    }
    public class DeleteLeaveCommandHandler(ILeaveRepository leaveRepository) : IRequestHandler<DeleteLeaveCommand, bool>
    {
        public async Task<bool> Handle(DeleteLeaveCommand request, CancellationToken cancellationToken)
        {
            var leaveId = request.LeaveId;
            return await leaveRepository.DeleteLeaveEntityAsync(leaveId);
        }
    }
}
 