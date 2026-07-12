using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios.Documentacao;

public static class CatalogoDocumentos
{
    private static readonly IReadOnlyList<MetadadosDocumento> Documentos =
    [
        new()
        {
            Codigo = "DNL-001",
            Titulo = "Visão da Plataforma",
            Slug = "visao-da-plataforma",
            Descricao = "Entenda por que o DotNetLabs foi criado, como o conhecimento é organizado e qual é a visão de futuro da plataforma.",
            Tipo = "Visão e propósito",
            Categoria = CategoriaDocumento.DotNetLabs,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "6 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 1
        },

        new()
        {
            Codigo = "DNL-002",
            Titulo = "Arquitetura da Plataforma",
            Slug = "arquitetura",
            Descricao = "Conheça a estrutura da solução, os projetos e as responsabilidades de cada camada do DotNetLabs.",
            Tipo = "Arquitetura",
            Categoria = CategoriaDocumento.DotNetLabs,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "8 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = false,
            EmBreve = true,
            Ordem = 2
        },

        new()
        {
            Codigo = "CMP-001",
            Titulo = "LabSection",
            Slug = "lab-section",
            Descricao = "Aprenda como utilizar o componente responsável por organizar as seções dos laboratórios e documentos.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "5 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = false,
            EmBreve = true,
            Ordem = 1
        }
    ];

    public static IReadOnlyList<MetadadosDocumento> ObterTodos()
    {
        return Documentos
            .OrderBy(x => x.Categoria)
            .ThenBy(x => x.Ordem)
            .ToList();
    }

    public static IReadOnlyList<MetadadosDocumento> ObterPorCategoria(
        CategoriaDocumento categoria,
        bool incluirNaoPublicados = true)
    {
        var consulta = Documentos
            .Where(x => x.Categoria == categoria);

        if (!incluirNaoPublicados)
        {
            consulta = consulta.Where(x => x.Publicado);
        }

        return consulta
            .OrderBy(x => x.Ordem)
            .ToList();
    }

    public static MetadadosDocumento? ObterPorCodigo(string codigo)
    {
        return Documentos.FirstOrDefault(x =>
            string.Equals(
                x.Codigo,
                codigo,
                StringComparison.OrdinalIgnoreCase));
    }

    public static MetadadosDocumento? ObterPorSlug(
        CategoriaDocumento categoria,
        string slug)
    {
        return Documentos.FirstOrDefault(x =>
            x.Categoria == categoria &&
            string.Equals(
                x.Slug,
                slug,
                StringComparison.OrdinalIgnoreCase));
    }
}
