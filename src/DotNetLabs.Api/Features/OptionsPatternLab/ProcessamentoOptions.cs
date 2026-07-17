namespace DotNetLabs.Api.Features.OptionsPatternLab
{
    public sealed class ProcessamentoOptions
    {
        public const string Secao = "Processamento";
        public int TempoLimiteSegundos { get; set; }
        public int QuantidadeMaximaTentativas { get; set; }
        public bool HabilitarLogsDetalhados { get; set; }
        public string Ambiente { get; set; } = string.Empty;
    }
}
