using System.Threading.Tasks;
using Abp.Application.Services;
using Restaurant.Authorization.Accounts.Dto;

namespace Restaurant.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
