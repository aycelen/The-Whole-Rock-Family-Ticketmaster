using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models
{
    [Table("Communication")]
    public class Communication
    {
        [Key]
        public int CommId { get; set; }
        [DisplayName("Adres")]
        [Required, StringLength(500, ErrorMessage = "500 Karekter olmalıdır.")]
        public string Address { get; set; }
        [DisplayName("Telefon")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string Tel { get; set; }
        [DisplayName("FAX")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string Fax { get; set; }

        [DisplayName("Whatsapp")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string Whatsapp { get; set; }

        [DisplayName("Facebook")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string Facebook { get; set; }

        [DisplayName("Twitter")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string Twitter { get; set; }

        [DisplayName("Instagram")]
        [Required, StringLength(50, ErrorMessage = "50 Karekter olmalıdır.")]
        public string Instagram { get; set; }
    }
}