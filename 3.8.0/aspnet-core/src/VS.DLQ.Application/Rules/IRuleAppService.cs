using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace VS.DLQ.Rules
{
    interface IRuleAppService
    {
        Task<ListResultDto<RuleDto>> GetAll();
    }
}
