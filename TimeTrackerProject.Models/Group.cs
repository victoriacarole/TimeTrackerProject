using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TimeTrackerProject.Models
{

    public class Group
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string GroupName { get; set; }
    }
}
