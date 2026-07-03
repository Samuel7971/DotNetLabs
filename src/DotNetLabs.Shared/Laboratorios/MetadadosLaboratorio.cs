using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios
{
    public sealed record MetadadosLaboratorio(
        string Id,
        string Titulo,
        string Descricao,
        CategoriaLaboratorio Categoria,
        DificuldadeLaboratorio Dificuldade,
        StatusLaboratorio Status,
        string TempoEstimado);
}
