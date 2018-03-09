using System.Threading.Tasks;
using Abp.Application.Services;
using erp2018abp.Configuration.Dto;

namespace erp2018abp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}