using Abp.Application.Services;
using TestXia.MultiTenancy.Dto;

namespace TestXia.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

