using System.Threading.Tasks;
using TestXia.Configuration.Dto;

namespace TestXia.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
