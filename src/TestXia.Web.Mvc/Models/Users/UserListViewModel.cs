using System.Collections.Generic;
using TestXia.Roles.Dto;

namespace TestXia.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
