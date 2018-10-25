using System.Threading.Tasks;
using Abp.Application.Services;
using PersonalCashFlow.Sessions.Dto;

namespace PersonalCashFlow.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
