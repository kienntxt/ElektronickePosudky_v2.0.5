using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace ElektronickePosudky.API.Controllers
{
    [ApiController]
    [Route("api/v2/ciselniky")]
    public sealed class CiselnikyController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<Resources.SharedResource> _localizer;

        public CiselnikyController(
            IMediator mediator,
            IStringLocalizer<Resources.SharedResource> localizer
        )
        {
            _mediator = mediator;
            _localizer = localizer;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<CiselnikDto>>> GetCiselniky(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId
        )
        {
            var items = await _mediator.Send(new GetCiselnikyQuery());
            return Ok(items);
        }

        [HttpGet("{kod}/polozky")]
        public async Task<ActionResult<IReadOnlyList<CiselnikPolozkaDto>>> GetPolozky(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            string kod
        )
        {
            var query = new GetCiselnikPolozkyQuery { Kod = kod };
            var items = await _mediator.Send(query);
            return Ok(items);
        }
    }
}
