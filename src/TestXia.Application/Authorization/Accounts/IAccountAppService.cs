using System.Threading.Tasks;
using Abp.Application.Services;
using TestXia.Authorization.Accounts.Dto;

namespace TestXia.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
