using System.Threading.Tasks;
using cursoazuredevops.Configuration.Dto;

namespace cursoazuredevops.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
