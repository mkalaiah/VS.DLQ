using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VS.DLQ.Configuration.Dto;

namespace VS.DLQ.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DLQAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
