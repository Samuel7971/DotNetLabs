using DotNetLabs.Shared.Laboratorios.Enums;

namespace DotNetLabs.Shared.Laboratorios.Extensions
{
    public static class DificuldadeLaboratorioExtensions
    {
        public static string Descricao(this DificuldadeLaboratorio dificuldade)
        {
            return dificuldade switch
            {
                DificuldadeLaboratorio.Iniciante => "Iniciante",
                DificuldadeLaboratorio.Intermediario => "Intermediário",
                DificuldadeLaboratorio.Avancado => "Avançado",
                _ => "-"
            };
        }

        public static string Icone(this DificuldadeLaboratorio dificuldade)
        {
            return dificuldade switch
            {
                DificuldadeLaboratorio.Iniciante => "bi bi-star",
                DificuldadeLaboratorio.Intermediario => "bi bi-star-half",
                DificuldadeLaboratorio.Avancado => "bi bi-star-fill",
                _ => "bi bi-question-circle"
            };
        }
    }
}
