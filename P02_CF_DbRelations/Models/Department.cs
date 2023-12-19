using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P02_CF_DbRelations.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Departman adı gerekli bilgidir..")]
        [StringLength(30, ErrorMessage = "Departman adı max.30 karakterdir...")]
        [Display(Name = "Departman Adı")]
        public string DepartmentName { get; set; }

        public ICollection<Personel> Personels { get; set; } // -->Personel tablosunu besliyor

    }
}
