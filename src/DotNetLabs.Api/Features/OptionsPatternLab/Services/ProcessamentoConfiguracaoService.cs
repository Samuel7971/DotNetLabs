using Microsoft.Extensions.Options;

namespace DotNetLabs.Api.Features.OptionsPatternLab.Services
{
    public class ProcessamentoConfiguracaoService(IOptions<ProcessamentoOptions> options) : IProcessamentoConfiguracaoService
    {
        private readonly ProcessamentoOptions _options = options.Value;

        public ProcessamentoOptions ObterConfiguracao()
        {
            return _options;
        }
    }
}
