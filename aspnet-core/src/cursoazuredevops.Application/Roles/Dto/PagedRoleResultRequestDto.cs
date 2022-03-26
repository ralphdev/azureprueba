using Abp.Application.Services.Dto;

namespace cursoazuredevops.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

