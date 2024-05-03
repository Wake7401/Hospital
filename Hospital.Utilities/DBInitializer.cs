using Microsoft.AspNetCore.Identity;
using Hospital.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital.Utilities
{
    public class DBInitializer : IDbInitializer
    {
        private UserManager<IdentityUser> __userManager;
        private RoleManager<IdentityRole> __roleManager;
        private ApplicationDbContext __context;

        public DBInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager,ApplicationDbContext context)
        {
            __userManager = userManager;
            __roleManager = roleManager;
            __context = context;
        }
        public void Initialize() {
            throw new NotImplementedException();
        }
    }
}
