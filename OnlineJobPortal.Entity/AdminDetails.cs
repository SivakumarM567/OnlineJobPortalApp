using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineJobPortal.Entity
{
    public class AdminDetails
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminMail { get; set; }
        public string AdminPassword { get; set; }
    }
}
