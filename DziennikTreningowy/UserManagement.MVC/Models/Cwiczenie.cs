using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public partial class Cwiczenie
    {
        public Cwiczenie()
        {
            Trenings = new HashSet<Trening>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CwiczenieID { get; set; }

        [Display(Name = "Nazwa ćwiczenia")]
        public string NazwaCwiczenia { get; set; }
        [Display(Name = "Ilość powtórzeń")]
        public int IloscPowtorzen { get; set; }
        [Display(Name = "Kategoria ćwiczenia")]
        public int KategoriaID { get; set; }
        public virtual Kategoria Kategorias { get; set; }
        public virtual ICollection<Trening> Trenings { get; set; }
    }
}
