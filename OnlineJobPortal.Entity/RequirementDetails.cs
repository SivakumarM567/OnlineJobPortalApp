using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineJobPortal.Entity
{
    public class RequirementDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }
        public string jobTitle { get; set; }
        public string Location { get; set; }
        public string Functional { get; set; }
        public string TechnicalSkills { get; set; } 
        public string Company { get; set; }
        public string ContactId { get; set; }
        public string contactperson { get; set; }
        public string ContactNo { get; set; }
    }
}
