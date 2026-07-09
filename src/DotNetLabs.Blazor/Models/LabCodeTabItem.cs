namespace DotNetLabs.Blazor.Models
{
    public sealed class LabCodeTabItem
    {
        public string Titulo { get; set; } = string.Empty;
        public string Language { get; set; } = "csharp";
        public string Code { get; set; } = string.Empty;
        public string? Icone { get; set; }
    }
}
