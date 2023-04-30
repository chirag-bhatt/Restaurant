using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Restaurant.Configuration.Dto;

namespace Restaurant.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RestaurantAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
