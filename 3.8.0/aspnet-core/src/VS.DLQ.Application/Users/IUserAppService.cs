using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VS.DLQ.Roles.Dto;
using VS.DLQ.Users.Dto;

namespace VS.DLQ.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
