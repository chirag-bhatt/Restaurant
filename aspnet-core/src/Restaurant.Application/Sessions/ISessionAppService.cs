using System.Threading.Tasks;
using Abp.Application.Services;
using Restaurant.Sessions.Dto;

namespace Restaurant.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
