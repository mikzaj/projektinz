using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public class Pomiar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PomiarID { get; set; }
        [Display(Name = "Wzrost")]
        public double WzrostID { get; set; }
        [Display(Name = "Waga")]
        public double WagaID { get; set; }
        [Display(Name = "Ramię")]
        public double RamieID { get; set; }
        [Display(Name = "Klatka piersiowa")]
        public double KlatkaID { get; set; }
        [Display(Name = "Talia")]
        public double TaliaID { get; set; }
        [Display(Name = "Udo")]
        public double UdaID { get; set; }
        [Display(Name = "Łydka")]
        public double LydkaID { get; set; }
    }
}
