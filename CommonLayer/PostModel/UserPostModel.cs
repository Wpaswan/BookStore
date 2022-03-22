using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.PostModel
{
    public class UserPostModel
    {


        public string FullName { get; set; }


        [RegularExpression(@"^[6-9]{1}[0-9]{9}$",
      ErrorMessage = "Please Enter Valid Phone Number")]
        public string phNo { get; set; }



        [RegularExpression(@"^[a-z0-9]+(.[a-z0-9]+)?@[a-z]+[.][a-z]{3}$",
  ErrorMessage = "Please Enter Valid Email")]
        public string EmailId { get; set; }


        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
  ErrorMessage = "Password Have minimum 8 Characters, Should have at least 1 Upper Case and Should have at least 1 numeric number and Has exactly 1 Special Character")]
        public string password { get; set; }



    }
}
