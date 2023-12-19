using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace P02_CF_DbRelations.Models
{
    public class AdSoyad
    {

        public string Ad { get; set; }

        public string Soyad { get; set; }

//        public ICollection<Personel> Personels { get; set; } // -->Personel tablosunu besliyor
    }
}
