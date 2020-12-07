using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TimeTrackerProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required]
        public UserType UsersType { get; set; }

        [Required, StringLength(80)]
        public string Password { get; set; }

        public string UniqueSalt { get; set; }

        public string TotalHours { get; set; }
    }
}