using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public partial class Kategoria
    { 
        public Kategoria()
        {
            Cwiczenies = new HashSet<Cwiczenie>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KategoriaID { get; set; }

        [Display(Name = "Nazwa Kategorii")]
        public string NazwaKategorii { get; set; }
        public virtual ICollection<Cwiczenie> Cwiczenies { get; set; }
    }
}
