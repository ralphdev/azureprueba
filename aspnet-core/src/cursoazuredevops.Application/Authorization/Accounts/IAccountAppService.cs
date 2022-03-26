using System.Threading.Tasks;
using Abp.Application.Services;
using cursoazuredevops.Authorization.Accounts.Dto;

namespace cursoazuredevops.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
