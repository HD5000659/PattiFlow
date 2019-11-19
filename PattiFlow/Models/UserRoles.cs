using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PattiFlow.Models
{
    public class UserRoles
    {
        [DisplayName("Username")]
        public string userName { get; set; }
        [DisplayName("Password")]
        public string password { get; set; }
    }
}