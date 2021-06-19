using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public class Trening
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TreningID { get; set; }
        [Display(Name = "Kategoria")]
        public int KategoriaID { get; set; }
        [Display(Name = "Ćwiczenie")]
        public int CwiczenieID { get; set; }

        [Display(Name = "Data treningu")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime DOB { get; set; }

        [Display(Name = "Czy wykonano?")]
        public bool isActive { get; set; }

        public virtual Cwiczenie Cwiczenies { get; set; }
    }

}
