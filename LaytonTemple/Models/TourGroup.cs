using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


//This is the model for the Groups. Phone is Optional

namespace LaytonTemple.Models
{
    public class TourGroup
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, 15)]
        public int Size { get; set; }
        [Required]
        public string Email { get; set; }
        public long? Phone { get; set; }

        public string Timeslot { get; set; }

    }
}
