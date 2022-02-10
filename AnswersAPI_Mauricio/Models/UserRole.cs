using System;
using System.Collections.Generic;

namespace AnswersAPI_Mauricio.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        public int UserRoleId { get; set; }
        public string UserRole1 { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
