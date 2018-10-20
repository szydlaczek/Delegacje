using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation.Core.Models
{
    public class User : CoreEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public User():base()
        {
            this.Roles = new HashSet<Role>();
        }
    }
}
