using DotNetLabs.Shared.Enums;
using DotNetLabs.Shared.Laboratorios.Cards;

namespace DotNetLabs.Shared.Laboratorios;

public sealed class MetadadosLaboratorio
{
    public string Id { get; init; } = string.Empty;
    public string Titulo { get; init; } = string.Empty;
    public string Descricao { get; init; } = string.Empty;
    public CategoriaLaboratorio Categoria { get; init; }
    public DificuldadeLaboratorio Dificuldade { get; init; }
    public StatusLaboratorio Status { get; init; }
    public string TempoEstimado { get; init; } = string.Empty;
    public string Icone { get; init; } = "🧪";
    public List<ContribuidorLaboratorio> Contribuidores { get; init; } = [];
    public required CardHome CardHome { get; init; }

}