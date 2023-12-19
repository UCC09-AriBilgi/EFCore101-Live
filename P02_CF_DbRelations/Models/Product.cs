using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P02_CF_DbRelations.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Ürün adı adı gerekli bilgidir..")]
        [StringLength(20, ErrorMessage = "Ürün adı max.20 karakterdir...")]
        [Display(Name = "Ürün Adı")]
        public string ProductName { get; set; }

        public virtual Category Categories { get; set; } // <-- Category besliyor

        public ICollection<Order> Orders { get; set; } // -->Order tablosunu besliyor



    }
}
