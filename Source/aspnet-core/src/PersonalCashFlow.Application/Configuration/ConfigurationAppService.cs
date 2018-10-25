using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PersonalCashFlow.Configuration.Dto;

namespace PersonalCashFlow.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PersonalCashFlowAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
