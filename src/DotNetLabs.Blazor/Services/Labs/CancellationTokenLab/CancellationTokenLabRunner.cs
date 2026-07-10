using DotNetLabs.Blazor.Models;
using System.Net.Http.Json;

namespace DotNetLabs.Blazor.Services.Labs.CancellationTokenLab;

public sealed class CancellationTokenLabRunner
{
    private readonly HttpClient _httpClient;

    public CancellationTokenLabRunner(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CancellationTokenLabResponse?> ExecutarAsync(
        int segundos,
        List<LabDemoLogItem> logs,
        CancellationToken cancellationToken = default)
    {
        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = "Requisição iniciada pelo Blazor.",
            Icone = "bi bi-pay-circle"
        });

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = "CancellationTokenSource criado.",
            Icone = "bi bi-lightning-charge"
        });

        var response = await _httpClient.GetAsync(
            $"https://localhost:7095/api/labs/cancellation-token/executar?segundos={segundos}",
            cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            logs.Add(new LabDemoLogItem
            {
                Horario = DateTime.Now,
                Mensagem = $"API retorno status {(int)response.StatusCode}.",
                Icone = "bi bi-exclamation-triangle"
            });

            return new CancellationTokenLabResponse
            {
                Status = "Erro",
                Mensagem = $"API retornou status {(int)response.StatusCode}."
            };
        }

        var resultado = await response.Content
            .ReadFromJsonAsync<CancellationTokenLabResponse>(cancellationToken: cancellationToken);

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = resultado?.Mensagem ?? "Operação finalizada com sucesso.",
            Icone = "bi bi-check-circle"
        });

        return resultado;
    }
}

