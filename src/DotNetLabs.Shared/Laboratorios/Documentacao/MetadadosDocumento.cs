using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios.Documentacao
{
    public sealed class MetadadosDocumento
    {
        public string Codigo { get; init; } = string.Empty;
        public string Titulo { get; init; } = string.Empty;
        public string Slug { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
        public string Tipo { get; init; } = string.Empty;
        public CategoriaDocumento Categoria { get; init; }
        public string Autor { get; init; } = string.Empty;
        public string TempoLeitura { get; init; } = string.Empty;
        public DateOnly DataPublicacao { get; init; }
        public DateOnly? DataAtualizacao { get; init; }
        public string Versao { get; init; } = "1.0";
        public bool Publicado { get; init; }
        public bool EmBreve { get; init; }
        public int Ordem { get; init; }
        public string Url => $"/documentacao/{Categoria.Slug()}/{Slug}";
    }
}
