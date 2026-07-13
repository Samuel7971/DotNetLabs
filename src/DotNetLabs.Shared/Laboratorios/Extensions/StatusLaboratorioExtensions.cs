using DotNetLabs.Shared.Enums;

namespace DotNetLabs.Shared.Laboratorios.Extensions;

public static class StatusLaboratorioExtensions
{
    public static string Descricao(this StatusLaboratorio status)
    {
        return status switch
        {
            StatusLaboratorio.Planejado => "Planejado",
            StatusLaboratorio.EmAndamento => "Em andamento",
            StatusLaboratorio.Disponivel => "Disponível",
            _ => "-"
        };
    }

    public static string Icone(this StatusLaboratorio status)
    {
        return status switch
        {
            StatusLaboratorio.Planejado => "bi bi-circle",
            StatusLaboratorio.EmAndamento => "bi bi-circle-fill text-warning",
            StatusLaboratorio.Disponivel => "bi bi-check-circle-fill text-success",
            _ => ""
        };
    }
}
