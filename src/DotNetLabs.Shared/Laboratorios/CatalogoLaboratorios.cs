using DotNetLabs.Shared.Laboratorios.Cards;
using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios
{
    public static class CatalogoLaboratorios
    {
        public static IReadOnlyList<MetadadosLaboratorio> ObterTodos()
        {
            return
            [
                new MetadadosLaboratorio()
                {
                    Id = "cancellation-token",
                    Titulo = "CancellationToken",
                    Descricao = "Entenda como cancelar operações assíncronas de forma cooperativa em aplicações .NET",
                    Categoria = CategoriaLaboratorio.Concorrencia,
                    Dificuldade = DificuldadeLaboratorio.Intermediario,
                    Status = StatusLaboratorio.EmAndamento,
                    TempoEstimado = "30 min",

                    CardHome = new CardHome()
                    {
                        DescricaoHome = "Aprenda a cancelar fluxos longos de forma segura e elegante.",
                        Icone = "⏱️",
                        Badge = ".NET",
                        DestaqueHome = true,
                        OrdemHome = 1,
                        CorCategoria = "#6D4AFF",
                        DataPublicacao = new DateOnly(2026, 7, 7),
                        Publicado = true,
                        EmBreve = false,
                    },

                    Contribuidores =
                    [
                         new()
                         {
                             Nome = "Samuel Rodrigues",
                             Cargo="Sofware Developer",
                             TipoContribuicao = TipoContribuicao.Autor
                         }
                    ]
                },
                new MetadadosLaboratorio()
                {
                    Id="Builder",
                    Titulo="Builder",
                    Descricao = "Construa objetos complexos com clareza e intenção.",
                    Categoria = CategoriaLaboratorio.PadroesDeProjeto,
                    Dificuldade = DificuldadeLaboratorio.Intermediario,
                    Status = StatusLaboratorio.Planejado,
                    TempoEstimado = "30 min",
                    CardHome = new CardHome()
                    {
                        DescricaoHome = "Construa objetos complexos com clareza e intenção.",
                        Icone = "🏗️",
                        Badge = "Patterns",
                        DestaqueHome = true,
                        OrdemHome = 3,
                        CorCategoria = "#6D4AFF",
                        DataPublicacao = new DateOnly(2026, 7, 6),
                        Publicado = false,
                        EmBreve = true,
                    },
                    Contribuidores =
                    [
                         new()
                         {
                             Nome = "Samuel Rodrigues",
                             Cargo="Sofware Developer",
                             TipoContribuicao = TipoContribuicao.Autor
                         }
                    ]
                },
                 new MetadadosLaboratorio()
                {
                    Id="Delegates",
                    Titulo="Delegates",
                    Descricao = "Entenda quando usar delegates no mundo real.",
                    Categoria = CategoriaLaboratorio.RecursoLinguagem,
                    Dificuldade = DificuldadeLaboratorio.Intermediario,
                    Status = StatusLaboratorio.Planejado,
                    TempoEstimado = "30 min",
                    CardHome = new CardHome()
                    {
                        DescricaoHome = "Entenda quando usar delegates no mundo real.",
                        Icone = "🧩",
                        Badge = "Delegates",
                        DestaqueHome = true,
                        OrdemHome = 2,
                        CorCategoria = "#6D4AFF",
                        DataPublicacao = new DateOnly(2026, 7, 6),
                        Publicado = false,
                        EmBreve = true,
                    },
                    Contribuidores =
                    [
                         new()
                         {
                             Nome = "Samuel Rodrigues",
                             Cargo="Sofware Developer",
                             TipoContribuicao = TipoContribuicao.Autor
                         },
                         new()
                         {
                             Nome = "Karina",
                             Cargo="Sofware Developer",
                             TipoContribuicao = TipoContribuicao.Coleborador
                         }
                    ]
                }
             ];
        }

        public static MetadadosLaboratorio? ObterPorId(string Id)
            => ObterTodos().FirstOrDefault(laboratorio => laboratorio.Id == Id);
    }
}
