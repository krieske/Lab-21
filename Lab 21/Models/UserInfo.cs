using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab_21.Models
{
    public class UserInfo
    {
        [Required]
        [RegularExpression("^[a-zA-Z]{2,30}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,30}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string PhoneNum { set; get; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string EmailAdd { set; get; }

        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$")]
        public string PassWord { set; get; }

        public UserInfo()
        {
            FirstName = "";
            LastName = "";
            PhoneNum = "";
            EmailAdd = "";
            PassWord = "";
        }

        public UserInfo(string fn, string ln, string pnum, string em, string pw)
        {
            FirstName = "fn";
            LastName = "ln";
            PhoneNum = "pnum";
            EmailAdd = "em";
            PassWord = "pw";
        }
    }
}