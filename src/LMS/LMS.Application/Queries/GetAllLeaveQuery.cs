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
    public record GetAllLeaveQuery() : IRequest<IEnumerable<LeaveEntity>>;

    public class GetAllLeaveQueryHandler(ILeaveRepository leaveRepository)
        : IRequestHandler<GetAllLeaveQuery, IEnumerable<LeaveEntity>>
    {
        public async Task<IEnumerable<LeaveEntity>> Handle(GetAllLeaveQuery request, CancellationToken cancellationToken)
        {
            return await leaveRepository.GetleavesAsync();
        }
    }
}
