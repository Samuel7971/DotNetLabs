using Microsoft.AspNetCore.Mvc;


namespace DotNetLabs.Api.Features.CancellationTokenLab;

[ApiController]
[Route("api/labs/cancellation-token")]
public class CancellationTokenController : ControllerBase
{
    private readonly CancellationTokenService _service;

    public CancellationTokenController(CancellationTokenService service)
    {
        _service = service;
    }

    [HttpGet("executar")]
    public async Task<IActionResult> ExecutaAsync([FromQuery] int segundos = 10, CancellationToken cancellationToken = default)
    {
        try
        {
            await _service.ProcessarAsync(segundos, cancellationToken);

            return Ok(new
            {
                status = "Finalizado",
                mensagem = $"Operação finalizada após {segundos} segundo(s)."
            });
        }
        catch (OperationCanceledException)
        {
            return StatusCode(499, new
            {
                status = "Cancelado",
                mensagem = "Operação cancelada pelo cliente."
            });
        }
    }
}
