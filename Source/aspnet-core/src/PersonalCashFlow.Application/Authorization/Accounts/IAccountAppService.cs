using System.Threading.Tasks;
using Abp.Application.Services;
using PersonalCashFlow.Authorization.Accounts.Dto;

namespace PersonalCashFlow.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
