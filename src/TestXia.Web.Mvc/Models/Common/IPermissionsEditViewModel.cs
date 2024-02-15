using System.Collections.Generic;
using TestXia.Roles.Dto;

namespace TestXia.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}