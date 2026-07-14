using DotNetLabs.Shared.Enums;

namespace DotNetLabs.Shared.Documentacao;

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
            Publicado = true,
            EmBreve = false,
            Ordem = 1
        },

        new()
        {
            Codigo = "CMP-002",
            Titulo = "LabLayout",
            Slug = "lab-layout",
            Descricao = "Aprenda como utilizar o componente responsável pela estrutura principal e pelo cabeçalho dos laboratórios.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "5 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 2
        },
        
        new()
        {
            Codigo = "CMP-003",
            Titulo = "LabAlert",
            Slug = "lab-alert",
            Descricao = "Veja como destacar avisos, informações importantes, alertas e boas práticas dentro dos laboratórios.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "4 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 3
        },
        
        new()
        {
            Codigo = "CMP-004",
            Titulo = "LabCodeBlock",
            Slug = "lab-code-block",
            Descricao = "Aprenda como exibir exemplos de código com linguagem, título e opção para copiar o conteúdo.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "6 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 4
        },
        
        new()
        {
            Codigo = "CMP-005",
            Titulo = "LabCodeTabs",
            Slug = "lab-code-tabs",
            Descricao = "Veja como organizar múltiplos exemplos de código em abas dentro de uma mesma seção.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "6 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 5
        },
        
        new()
        {
            Codigo = "CMP-006",
            Titulo = "LabObjective",
            Slug = "lab-objective",
            Descricao = "Aprenda como apresentar de forma clara os objetivos e resultados esperados de um laboratório.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "4 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 6
        },
        
        new()
        {
            Codigo = "CMP-007",
            Titulo = "LabFlow",
            Slug = "lab-flow",
            Descricao = "Veja como representar visualmente as etapas e a sequência de aprendizado de um laboratório.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "5 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 7
        },
        
        new()
        {
            Codigo = "CMP-008",
            Titulo = "LabDemo",
            Slug = "lab-demo",
            Descricao = "Aprenda como criar áreas interativas para executar demonstrações e apresentar logs e resultados.",
            Tipo = "Componente reutilizável",
            Categoria = CategoriaDocumento.Componentes,
            Autor = "Samuel Rodrigues",
            TempoLeitura = "6 min de leitura",
            DataPublicacao = new DateOnly(2026, 7, 11),
            Versao = "1.0",
            Publicado = true,
            EmBreve = false,
            Ordem = 8
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
