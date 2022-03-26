using Abp.Application.Services;
using cursoazuredevops.MultiTenancy.Dto;

namespace cursoazuredevops.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

