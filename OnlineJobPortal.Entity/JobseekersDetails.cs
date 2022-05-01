using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineJobPortal.Entity
{
    class JobseekersDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public string TechnicalSkills { get; set; }
        public int Experience { get; set; }
    }
}
