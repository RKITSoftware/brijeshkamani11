using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class Movies
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Display(Name = "Released Date")]
        public DateTime ReleasedDate { get; set; }

        [Display(Name = "Is Released")]
        public bool IsRelased { get; set; }

        [Display(Name = "Rent Price")]
        public short RentPrice { get; set; }

        [Display(Name = "Buy Price")]
        public int BuyPrice { get; set; }
    }
}