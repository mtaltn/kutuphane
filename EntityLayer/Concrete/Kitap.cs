using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }

        [StringLength(51)]
        public string kitapbasligi { get; set; }

       
        public int ISBN { get; set; }
        public DateTime yayinyili { get; set; }
        public decimal fiyat { get; set; }
        public bool check { get; set; }


        public int? aliciid { get; set; }
        public virtual Alici Alici { get; set; }
        public DateTime? verilistarihi { get; set; }
        public DateTime? donustarihi { get; set; }


    }
}
