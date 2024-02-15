using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestXia.Configuration.Dto;

namespace TestXia.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestXiaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
