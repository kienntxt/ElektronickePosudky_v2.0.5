using ElektronickePosudky.Application.Commands;
using ElektronickePosudky.Application.DTO;
using ElektronickePosudky.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace ElektronickePosudky.API.Controllers
{
    [ApiController]
    [Route("api/v2/posudky/ridicskeOpravneni")]
    public sealed class PosudkyController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStringLocalizer<Resources.SharedResource> _localizer;

        public PosudkyController(
            IMediator mediator,
            IStringLocalizer<Resources.SharedResource> localizer
        )
        {
            _mediator = mediator;
            _localizer = localizer;
        }

        [HttpPost]
        public async Task<ActionResult<PosudekRoCreateResultDto>> Create(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            [FromBody] PosudekRoCreateDto request
        )
        {
            var result = await _mediator.Send(new CreatePosudekCommand { Posudek = request });
            return Created(string.Empty, result);
        }

        [HttpPost("vyhledat")]
        public async Task<ActionResult<PosudekRoDetailDtoPageResponse>> Search(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            [FromBody] PosudkyRoSearchRequest request
        )
        {
            var result = await _mediator.Send(new SearchPosudkyQuery { SearchRequest = request });
            return Ok(result);
        }

        [HttpGet("{id}/pdf")]
        public async Task<IActionResult> GetPdf(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            Guid id
        )
        {
            var bytes = await _mediator.Send(new GetPosudekPdfQuery { Id = id });
            return File(bytes, "application/pdf", $"posudek-{id}.pdf");
        }

        [HttpGet("{id}/historie")]
        public async Task<ActionResult> GetHistory(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            Guid id
        )
        {
            var result = await _mediator.Send(new GetPosudekHistoryQuery { Id = id });
            return Ok(result);
        }

        [HttpPatch("{id}/zneplatnit")]
        public async Task<ActionResult<PosudekRoDetailDto>> Invalidate(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            [FromHeader(Name = "If-Match")] string ifMatch,
            Guid id
        )
        {
            if (string.IsNullOrWhiteSpace(ifMatch))
            {
                return BadRequest(
                    new ProblemDetails
                    {
                        Title = _localizer["IfMatchRequired"],
                        Status = 400,
                        Detail = _localizer["IfMatchHeaderMissing"],
                    }
                );
            }

            var result = await _mediator.Send(
                new InvalidatePosudekCommand { Id = id, IfMatch = ifMatch.ToString().Trim('"') }
            );
            return Ok(result);
        }

        [HttpPost("zalozeni/opravneni")]
        public async Task<ActionResult<PosudekRoOpravneniResponseDto>> CheckOpravneni(
            [FromHeader(Name = "Accept-Language")] string acceptLanguage,
            [FromHeader(Name = "X-Correlation-Id")] string correlationId,
            [FromBody] PosudekRoOpravneniRequestDto request
        )
        {
            var result = await _mediator.Send(new CheckOpravneniCommand { Request = request });
            return Ok(result);
        }
    }
}
