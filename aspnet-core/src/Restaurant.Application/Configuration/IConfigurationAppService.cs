using System.Threading.Tasks;
using Restaurant.Configuration.Dto;

namespace Restaurant.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
