namespace DotNetLabs.Blazor.Models
{
    public sealed class LabDemoLogItem
    {
        public DateTime Horario { get; set; } = DateTime.Now;
        public string Mensagem { get; set; } = string.Empty;
        public string Icone { get; set; } = "bi bi-check-circle";
    }
}
