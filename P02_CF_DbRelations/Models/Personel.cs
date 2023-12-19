using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P02_CF_DbRelations.Models
{
    public class Personel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonelID { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        [Required(ErrorMessage = "Personel adı gerekli bilgidir..")]
        [StringLength(20, ErrorMessage = "Personel adı max.20 karakterdir...")]
        [Display(Name = "Personel Adı")]
        public string FName { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "Personel soyadı gerekli bilgidir..")]
        [StringLength(30, ErrorMessage = "Personel soyadı max.30 karakterdir...")]
        [Display(Name = "Personel Soyadı")]
        public string LName { get; set; }

        // İlişkilerin belirtilmesi - Departmanclass ı ile ilişkilendiriliyor
        public virtual Department Departments { get; set; } // <-- Department class dan geliyor..yani oradan besleniyor

        public virtual City Cities { get; set; } // <-- City class


    }
}
