using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios.Extensions
{
    public static class CategoriaLaboratorioExtensions
    {
        public static string Descricao(this CategoriaLaboratorio categoria)
        {
            return categoria switch
            {
                CategoriaLaboratorio.Concorrencia => "Concorrência",
                CategoriaLaboratorio.PadroesDeProjeto => "Padrões de Projeto",
                CategoriaLaboratorio.Arquitetura => "Arquitetura",
                CategoriaLaboratorio.Seguranca => "Segurança",
                CategoriaLaboratorio.Performance => "Performance",
                CategoriaLaboratorio.Testes => "Testes",
                CategoriaLaboratorio.BancoDeDados => "Banco de Dados",
                CategoriaLaboratorio.Mensageria => "Mensageria",
                CategoriaLaboratorio.SystemDesign => "System Design",
                _ => "-"
            };
        }

        public static string Icone(this CategoriaLaboratorio categoria)
        {
            return categoria switch
            {
                CategoriaLaboratorio.Concorrencia => "bi bi-diagram-3",
                CategoriaLaboratorio.PadroesDeProjeto => "bi bi-boxes",
                CategoriaLaboratorio.Arquitetura => "bi bi-building",
                CategoriaLaboratorio.Seguranca => "bi bi-shield-lock",
                CategoriaLaboratorio.Performance => "bi bi-speedometer2",
                CategoriaLaboratorio.Testes => "bi bi-check2-square",
                CategoriaLaboratorio.BancoDeDados => "bi bi-database",
                CategoriaLaboratorio.Mensageria => "bi bi-envelope-paper",
                CategoriaLaboratorio.SystemDesign => "bi bi-share",
                _ => "bi bi-question-circle"
            };
        }
    }
}
