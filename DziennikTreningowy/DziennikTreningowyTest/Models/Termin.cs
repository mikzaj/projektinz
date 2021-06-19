using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public partial class Termin
    {
        public Termin()
        {
            Trenings = new HashSet<Trening>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TerminID { get; set; }
        public int day { get; }
        public virtual ICollection<Trening> Trenings { get; set; }
    }
}