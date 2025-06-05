using LMS.Core.Entities;
using LMS.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application.Queries
{
    public record GetLeaveByIdQuery(Guid leaveId) : IRequest<LeaveEntity>
    {
        public Guid LeaveId { get; } = leaveId;
    }

    public class GetLeaveByIdQueryHandler(ILeaveRepository leaveRepository)
        : IRequestHandler<GetLeaveByIdQuery, LeaveEntity>
    {
        public async Task<LeaveEntity> Handle(GetLeaveByIdQuery request, CancellationToken cancellationToken)
        {
            var leaveId = request.leaveId;
            return await leaveRepository.GetLeaveEntityAsync(leaveId);
        }
    }
}
