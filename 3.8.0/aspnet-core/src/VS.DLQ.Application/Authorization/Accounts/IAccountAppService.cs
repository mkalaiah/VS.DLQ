using System.Threading.Tasks;
using Abp.Application.Services;
using VS.DLQ.Authorization.Accounts.Dto;

namespace VS.DLQ.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
