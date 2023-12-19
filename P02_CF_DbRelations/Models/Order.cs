using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P02_CF_DbRelations.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public virtual Personel Personels { get; set; } // <-- Personel besleycek

        public virtual Product Products { get; set; } // <-- Product besleycek



    }
}
