using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PersonalCashFlow.MultiTenancy.Dto;

namespace PersonalCashFlow.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
