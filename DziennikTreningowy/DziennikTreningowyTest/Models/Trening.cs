using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public class Trening
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TreningID { get; set; }
        public int KategoriaID { get; set; }
        public int TerminID { get; set; }

    }
//    public virtual Kategoria Kategoria { get; set; }
//    public virtual Termin Termin { get; set; }
}
