using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaytonTemple.Models
{
    public partial class Times
    {
        [Key]
        [Required]
        public int TimeId { get; set; }

        [Required]
        public string Timeslot { get; set; }

        public bool Available { get; set; } = true;
    }
}
