using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Models
{
    public class PersonModel
    {
     [Required]
     [StringLength(20)]
        public string  address {get;set;}
        [StringLength(20)]
        [Required]
        public string password { get; set; }
        [StringLength(20)]
        [Required]
        public string firstname { get; set; }
        [StringLength(20)]
        [Required]
        public string lastname { get; set; }
        [Required]
        [Range (1,31)]
        public int day { get; set; }
        [Required]
        public int month{ get; set; }
        [Required]
        public int year { get; set; }
    }
}
