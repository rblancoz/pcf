using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PersonalCashFlow.Roles.Dto;
using PersonalCashFlow.Users.Dto;

namespace PersonalCashFlow.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
