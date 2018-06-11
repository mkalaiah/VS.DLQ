using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VS.DLQ.MultiTenancy.Dto;

namespace VS.DLQ.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
