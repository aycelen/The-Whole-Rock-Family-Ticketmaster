using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models.Model
{
    [Table("Slider")]
    public class Slider
    {
        
        [Key]
        public int SliderId { get; set; }
        [Required]
        [DisplayName("Slider Başlığı")]

        public string Baslik { get; set; }
        [DisplayName("Slider Açıklama")]

        public string Aciklama { get; set; }
        [DisplayName("Slider Resim")]

        public string ResimUrl { get; set; }


    }
}