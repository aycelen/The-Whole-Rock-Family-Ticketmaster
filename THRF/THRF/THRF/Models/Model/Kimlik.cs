using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models.Model
{
    [Table("Kimlik")]
    public class Kimlik
    {
        [Key]
        public int KimlikId { get; set; }
        [DisplayName("Site Başlık")]
        [Required,StringLength(100,ErrorMessage ="100 Karekter olmalıdır.")]
        public string  Title { get; set; }
        [DisplayName("Anahtar Kelimeler")]
        [Required, StringLength(100, ErrorMessage = "250 Karekter olmalıdır.")]
        public string Keywords { get; set; }
        [DisplayName("Site Açıklama")]
        [Required, StringLength(500, ErrorMessage = "500 Karekter olmalıdır.")]
        public string Decription { get; set; }
        [DisplayName("Site Logo")]
        [Required, StringLength(250, ErrorMessage = "250 Karekter olmalıdır.")]
        public string LogoUrl { get; set; }
        [DisplayName("Site Unvan")]
        [Required, StringLength(250, ErrorMessage = "250 Karekter olmalıdır.")]
        public string Unvan { get; set; }
    }
}