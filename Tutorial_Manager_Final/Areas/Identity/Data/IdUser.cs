using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Tutorial_Manager_Final.Areas.Identity.Data;

// Add profile data for application users by adding properties to the IdUser class
public class IdUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

