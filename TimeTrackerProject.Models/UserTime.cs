using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TimeTrackerProject.Models
{
    public class UserTime
    {
        [Key]
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime StopTime { get; set; }

        public string WorkComments { get; set; }

        public string TotalHours { get; set; }


        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
