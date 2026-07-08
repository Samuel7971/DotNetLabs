using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLabs.Shared.Laboratorios.Cards
{
    public sealed class CardHome
    {
        public string DescricaoHome { get; set; } = string.Empty;
        public string Badge { get; init; } = ".NET";
        public bool DestaqueHome { get; init; }
        public int OrdemHome { get; init; } = 999;
        public string CorCategoria { get; init; } = "#6D4AFF";
        public DateOnly? DataPublicacao { get; init; }
        public bool Publicado { get; init; } = true;
        public bool EmBreve { get; init; }
        public string Icone { get; init; } = "🧪";
    }
}
