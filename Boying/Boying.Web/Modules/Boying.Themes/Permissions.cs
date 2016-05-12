using System.Collections.Generic;
using Boying.Environment.Extensions.Models;
using Boying.Security.Permissions;

namespace Boying.Themes {
    public class Permissions : IPermissionProvider {
        public static readonly Permission ApplyTheme = new Permission { Description = "Apply a Theme", Name = "ApplyTheme" };

        public virtual Feature Feature { get; set; }

        public IEnumerable<Permission> GetPermissions() {
            return new[] {
                                        ApplyTheme,
                                    };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return new[] {
                             new PermissionStereotype {
                                                          Name = "Administrator",
                                                          Permissions = new[] {ApplyTheme}
                                                      },
                         };
        }
    }
}