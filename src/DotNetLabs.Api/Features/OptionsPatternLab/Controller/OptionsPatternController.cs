using DotNetLabs.Api.Features.OptionsPatternLab.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLabs.Api.Features.OptionsPatternLab.Controller
{
    [ApiController]
    [Route("api/labs/options-pattern")]
    public sealed class OptionsPatternController(IProcessamentoConfiguracaoService service) : ControllerBase
    {
        private readonly IProcessamentoConfiguracaoService _service = service;


        [HttpGet("executar")]
        [ProducesResponseType<ProcessamentoOptions>(StatusCodes.Status200OK)]
        public async Task<IActionResult> ExecutaAsync()
        {
            var configuracao = _service.ObterConfiguracao();

            return Ok(configuracao);
        }
    }
}
