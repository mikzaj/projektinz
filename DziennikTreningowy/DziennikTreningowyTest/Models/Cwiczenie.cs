using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DziennikTreningowy.Models
{
    public partial class Cwiczenie
    {
        public Cwiczenie()
        {
            Kategorias = new HashSet<Kategoria>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CwiczenieID { get; set; }
        public int IloscPowtorzen { get; set; }
        public string NazwaCwiczenia { get; set; }
        public virtual ICollection<Kategoria> Kategorias { get; set; }
    }
}
