using DotNetLabs.Blazor.Models;
using System.Net.Http.Json;

namespace DotNetLabs.Blazor.Services.Labs.OptionsPatternLab;

public sealed class OptionsPatternLabRunner(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<OptionsPatternLabResponse?> ExecutarAsync(
        List<LabDemoLogItem> logs,
        CancellationToken cancellationToken = default)
    {
        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = "Demonstração do Options Pattern iniciada.",
            Icone = "bi bi-play-circle"
        });

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = "Solicitando as configurações para a API.",
            Icone = "bi bi-cloud-arrow-down"
        });

        try
        {
            var response = await _httpClient.GetAsync(
                "https://localhost:7095/api/labs/options-pattern/executar",
                cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                logs.Add(new LabDemoLogItem
                {
                    Horario = DateTime.Now,
                    Mensagem =
                        $"A API retornou o status {(int)response.StatusCode}.",
                    Icone = "bi bi-exclamation-triangle"
                });

                return new OptionsPatternLabResponse
                {
                    Status = "Erro",
                    Mensagem =
                        $"A API retornou o status {(int)response.StatusCode}."
                };
            }

            var resultado = await response.Content
                .ReadFromJsonAsync<OptionsPatternLabResponse>(
                    cancellationToken: cancellationToken);

            if (resultado is null)
            {
                logs.Add(new LabDemoLogItem
                {
                    Horario = DateTime.Now,
                    Mensagem = "A API não retornou uma configuração válida.",
                    Icone = "bi bi-exclamation-triangle"
                });

                return new OptionsPatternLabResponse
                {
                    Status = "Erro",
                    Mensagem = "Não foi possível ler a resposta da API."
                };
            }

            AdicionarLogsConfiguracao(resultado, logs);

            return resultado;
        }
        catch (OperationCanceledException)
        {
            logs.Add(new LabDemoLogItem
            {
                Horario = DateTime.Now,
                Mensagem = "A requisição foi cancelada.",
                Icone = "bi bi-x-circle"
            });

            return new OptionsPatternLabResponse
            {
                Status = "Cancelado",
                Mensagem = "A requisição foi cancelada."
            };
        }
        catch (HttpRequestException exception)
        {
            logs.Add(new LabDemoLogItem
            {
                Horario = DateTime.Now,
                Mensagem = "Não foi possível acessar a API.",
                Icone = "bi bi-wifi-off"
            });

            return new OptionsPatternLabResponse
            {
                Status = "Erro",
                Mensagem = exception.Message
            };
        }
    }

    private static void AdicionarLogsConfiguracao(
        OptionsPatternLabResponse resultado,
        List<LabDemoLogItem> logs)
    {
        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem =
                $"Tempo limite carregado: {resultado.TempoLimiteSegundos} segundos.",
            Icone = "bi bi-clock"
        });

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem =
                $"Quantidade máxima de tentativas: {resultado.QuantidadeMaximaTentativas}.",
            Icone = "bi bi-arrow-repeat"
        });

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = resultado.HabilitarLogsDetalhados
                ? "Logs detalhados estão habilitados."
                : "Logs detalhados estão desabilitados.",
            Icone = "bi bi-card-text"
        });

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = $"Ambiente configurado: {resultado.Ambiente}.",
            Icone = "bi bi-hdd-stack"
        });

        logs.Add(new LabDemoLogItem
        {
            Horario = DateTime.Now,
            Mensagem = resultado.Mensagem,
            Icone = "bi bi-check-circle"
        });
    }
}