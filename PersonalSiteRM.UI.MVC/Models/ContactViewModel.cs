using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalSiteRM.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "* Your name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="* Let me know how I can reach you.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [UIHint("MultilineText")]
        [Required(ErrorMessage = "* Please write something for me.")]
        public string Message { get; set; }
    }
}