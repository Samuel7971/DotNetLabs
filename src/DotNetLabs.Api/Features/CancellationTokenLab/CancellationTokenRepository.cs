using Dapper;
using System.Data.Common;

namespace DotNetLabs.Api.Features.CancellationTokenLab;

public class CancellationTokenRepository
{
    public Action<string>? Logger { get; set; }

    public async Task ExecutarOperacaoDemoradaAsync(int segundos, CancellationToken cancellationToken)
    {
        for (var i = 1; i <= segundos; i++)
        {
            Logger?.Invoke($"Executando segundo {i}...");

            cancellationToken.ThrowIfCancellationRequested();

            await Task.Delay(1000, cancellationToken);
        }

        Logger?.Invoke("Processamento finalizado.");
    }

    //public async Task<IEnumerable<Produto>> BuscarProdutosAsync(CancellationToken cancellationToken)
    //{
    //    var sql = $@"";

    //    var command = new CommandDefinition(
    //        sql,
    //        cancellationToken: cancellationToken);

    //    return await _connection.QueryAsync<Produto>(command);
    //}
}
