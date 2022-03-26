using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using cursoazuredevops.Configuration.Dto;

namespace cursoazuredevops.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : cursoazuredevopsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
