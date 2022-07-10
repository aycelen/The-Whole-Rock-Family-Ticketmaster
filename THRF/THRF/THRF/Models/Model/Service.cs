using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models.Model

{
    [Table("Service")]

    public class Service
    {
        [Key]
        public int SerId { get; set; }

        [DisplayName("Hizmet Açıklaması")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string SerHead { get; set; }
        [DisplayName("Hizmet Kime Karşı Yapılır")]
        [Required, StringLength(500, ErrorMessage = "50 0Karekter olmalıdır.")]
        public string SerEx { get; set; }
        [DisplayName("Hizmet")]
        [Required, StringLength(500, ErrorMessage = "50 0Karekter olmalıdır.")]
        public string SerMail { get; set; }

    }
}