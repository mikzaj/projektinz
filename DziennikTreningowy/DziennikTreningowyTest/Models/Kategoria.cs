using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public partial class Kategoria
    { 
        public Kategoria()
        {
            Trenings = new HashSet<Trening>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KategoriaID { get; set; }
        public string NazwaKategorii { get; set; }
        public virtual Cwiczenie Cwiczenie { get; set; }
        public virtual ICollection<Trening> Trenings { get; set; }
    }
}
