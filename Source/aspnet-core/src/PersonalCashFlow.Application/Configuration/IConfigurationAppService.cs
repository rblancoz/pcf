using System.Threading.Tasks;
using PersonalCashFlow.Configuration.Dto;

namespace PersonalCashFlow.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
