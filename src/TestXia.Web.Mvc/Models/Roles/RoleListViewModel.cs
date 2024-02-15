using System.Collections.Generic;
using TestXia.Roles.Dto;

namespace TestXia.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
