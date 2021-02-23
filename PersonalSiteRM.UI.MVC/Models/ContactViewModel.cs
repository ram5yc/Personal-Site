using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSiteRM.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Tell me your name!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="* I need to know how I can reach you!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [UIHint("MultilineText")]
        [Required(ErrorMessage = "* Please write something for me.")]
        public string Message { get; set; }
    }
}