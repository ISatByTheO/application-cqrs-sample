using System;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sample.Business.Applications;
using Sample.Business.Applications.AddApplication;
using Sample.Business.Applications.GetApplication;

namespace Sample.Api.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApplicationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ApplicationDto), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> AddApplication([FromBody] AddApplicationRequest request)
        {
            var application = await _mediator.Send(new AddApplicationCommand(request.Firstname, request.Lastname, request.Email, request.DateOfBirth));

            return Created(string.Empty, application);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ApplicationDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetApplication(Guid guid)
        {
            var application = await _mediator.Send(new GetApplicationQuery(guid));

            return Ok(application);
        }
    }
}
