namespace DotNetLabs.Blazor.Services.Labs.OptionsPatternLab
{
    public class OptionsPatternLabResponse
    {
        public int TempoLimiteSegundos { get; set; }
        public int QuantidadeMaximaTentativas { get; set; }
        public bool HabilitarLogsDetalhados { get; set; }
        public string Ambiente { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
    }
}
