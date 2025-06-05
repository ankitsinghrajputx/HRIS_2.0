using LMS.Application.Commands;
using LMS.Application.Queries;
using LMS.Core.Entities;
using LMS.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using System.Reflection;

namespace LMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeavesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Leaves/GetleavesAsync
        [HttpGet("GetleavesAsync")]
        public async Task<ActionResult> GetleavesAsync()
        {
            var result = await _mediator.Send(new GetAllLeaveQuery());
            return Ok(result);
        }

        // GET: api/Leaves/GetLeaveEntityAsync/5
        [HttpGet("GetLeaveEntityAsync/{leaveId}")]
        public async Task<ActionResult> GetLeaveEntityAsync(Guid leaveId)
        {
            var result = await _mediator.Send(new GetLeaveByIdQuery(leaveId));
            return Ok(result);
        }

        // POST: api/Leaves/AddLeaveEntityAsync
        [HttpPost("AddLeaveEntityAsync")]
        public async Task<ActionResult> AddLeaveEntityAsync(LeaveEntity leaveEntity)
        {
            var result = await _mediator.Send(new AddLeaveCommand(leaveEntity));
            return Ok(result);
        }

        // PUT: api/Leaves/UpdateLeaveEntityAsync/5
        [HttpPut("UpdateLeaveEntityAsync/{leaveId}")]
        public async Task<IActionResult> UpdateLeaveEntityAsync(Guid leaveId, LeaveEntity leaveEntity)
        {
            var result = await _mediator.Send(new UpdateLeaveCommand(leaveId, leaveEntity));
            return Ok(result);
        }

        // DELETE: api/Leaves/DeleteLeaveEntityAsync/5
        [HttpDelete("DeleteLeaveEntityAsync/{leaveId}")]
        public async Task<IActionResult> DeleteLeaveEntityAsync(Guid leaveId)
        {
            var result = await _mediator.Send(new DeleteLeaveCommand(leaveId));
            return Ok(result);
        }
    }
}
