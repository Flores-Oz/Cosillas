using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Brand()
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int brandID { get; set; }
        public string? nameBrand { get; set; } // Cambiado a nullable
        public virtual ICollection<Beer>? Beers { get; set; }
    }
}
