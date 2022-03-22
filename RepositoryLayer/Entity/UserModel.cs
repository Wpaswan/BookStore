using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Entity
{
    public class UserModel
    {

        public int UserId { get; set; }
        public string FullName { get; set; }

        public string EmailId { get; set; }

        public string password { get; set; }
        public string phNo { get; set; }

    }
}
