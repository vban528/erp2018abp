using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using erp2018abp.Configuration.Dto;

namespace erp2018abp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : erp2018abpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
