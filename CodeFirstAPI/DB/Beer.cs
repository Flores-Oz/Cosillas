using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Beer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int beerID { get; set; }
        public string? nameBeer { get; set; }
        public int brandID { get; set; }

        [ForeignKey("brandID")]
        public virtual Brand? Brand { get; set; }
    }
}
