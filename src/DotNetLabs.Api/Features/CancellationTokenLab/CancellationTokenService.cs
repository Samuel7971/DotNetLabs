namespace DotNetLabs.Api.Features.CancellationTokenLab;

public sealed class CancellationTokenService
{
    private readonly CancellationTokenRepository _repository;

    public CancellationTokenService(CancellationTokenRepository repository) => _repository = repository;

    public async Task ProcessarAsync(int segundos, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        _repository.Logger = mensagem =>
        {
            Console.WriteLine(mensagem);
        };

        await _repository.ExecutarOperacaoDemoradaAsync(segundos, cancellationToken);
    }
}
