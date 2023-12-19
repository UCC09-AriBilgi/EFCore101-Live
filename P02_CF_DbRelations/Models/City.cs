using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P02_CF_DbRelations.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }

        [Required(ErrorMessage = "Şehir adı gerekli bilgidir..")]
        [StringLength(20, ErrorMessage = "Şehir adı max.20 karakterdir...")]
        [Display(Name = "Şehir Adı")]
        public string CityName { get; set; }
    }
}
