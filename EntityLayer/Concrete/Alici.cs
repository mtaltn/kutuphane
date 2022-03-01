using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Alici
    {
        [Key]
        public int aliciid { get; set; }
        [StringLength(51)]
        public string aliciadi { get; set; }

        
        public int alicitelefon { get; set; }

        
        public int alicitc { get; set; }
        public DateTime checkdate { get; set; }
        public DateTime deliverydate { get; set; }

        public ICollection<Kitap> Kitaplar { get; set; }
    }
}
