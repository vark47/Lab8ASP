using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesSong.Models
{
    public class Song
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Writer { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Composer { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Artist { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Album { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }
    }
}
