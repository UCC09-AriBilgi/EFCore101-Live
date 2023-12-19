using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_CF_DbRelations.Models
{
    // Ürün kategorileri tutacak class(table) yapısı
    public class Category
    {
        // Db tarafında tablo üzerinde design olarak yapmış olduğumuz işlemleri(key,identity,veri tipi belirleme ...) Code tarafında da yapabiliyoruz.
        // BUna DataAnnotations ismi veriliyor. Yani buradan table design yapabiliyorum.

        // primary Key olduğunu belirttim..Otomatik artan olarak da tanımladım.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Kategori adı gerekli bilgidir..")]
        [StringLength(30,ErrorMessage ="Kategori adı max.30 karakterdir...")]
        [Display(Name ="Kategori Adı")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; } // -->Product tablosunu besliyor

    }
}
