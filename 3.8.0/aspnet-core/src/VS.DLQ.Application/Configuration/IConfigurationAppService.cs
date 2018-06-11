using System.Threading.Tasks;
using VS.DLQ.Configuration.Dto;

namespace VS.DLQ.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
