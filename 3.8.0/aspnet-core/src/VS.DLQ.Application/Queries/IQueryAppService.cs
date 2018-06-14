using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VS.DLQ.Queries.Dto;

namespace VS.DLQ.Queries
{
    public interface IQueryAppService : IApplicationService
    {
        Task<string> Create(CreateQueryDto input);

        Task<ListResultDto<QueryDto>> GetAll();
    }
}
