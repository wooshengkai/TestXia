using System.Threading.Tasks;
using Abp.Application.Services;
using TestXia.Sessions.Dto;

namespace TestXia.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
