using System.Threading.Tasks;
using Abp.Application.Services;
using VS.DLQ.Queries.Dto;

namespace VS.DLQ.Queries
{
    public interface IQueryAppService: IApplicationService
    {
        Task CreateAsync(CreateQueryDto input);
    }
}
