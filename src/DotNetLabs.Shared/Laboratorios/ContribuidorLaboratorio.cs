using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios
{
    public sealed class ContribuidorLaboratorio
    {
        public string Nome { get; init; } = string.Empty;
        public string? Cargo { get; init; }
        public string? AvatarUri { get; init; }
        public TipoContribuicao TipoContribuicao { get; init; } = TipoContribuicao.Coleborador;
    }
}
