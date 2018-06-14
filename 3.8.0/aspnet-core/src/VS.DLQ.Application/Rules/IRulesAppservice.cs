using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace VS.DLQ.Rules
{
    interface IRulesAppservice
    {
        Task<ListResultDto<RuleDto>> GetAll();
    }
}
