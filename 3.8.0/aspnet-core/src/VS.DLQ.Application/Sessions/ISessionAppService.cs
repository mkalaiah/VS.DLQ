using System.Threading.Tasks;
using Abp.Application.Services;
using VS.DLQ.Sessions.Dto;

namespace VS.DLQ.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
