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

    public class AddLeaveCommand(LeaveEntity leaveEntity) : IRequest<LeaveEntity> 
    {
        public LeaveEntity LeaveEntity { get; } = leaveEntity;
    }
    public class AddLeaveCommandHandler(ILeaveRepository leaveRepository) : IRequestHandler<AddLeaveCommand, LeaveEntity>
    {
        public async Task<LeaveEntity> Handle(AddLeaveCommand request, CancellationToken cancellationToken)
        {
            var leaveEntity = request.LeaveEntity;
            return await leaveRepository.AddLeaveEntityAsync(leaveEntity);
        }
    }
}
 