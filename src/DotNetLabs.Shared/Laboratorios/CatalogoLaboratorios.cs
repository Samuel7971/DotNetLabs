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
                    TempoEstimado = "30 min"
                }
             ];
        }

        public static MetadadosLaboratorio? ObterPorId(string Id)
            => ObterTodos().FirstOrDefault(laboratorio => laboratorio.Id == Id);
    }
}
