using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required,StringLength(50,ErrorMessage ="50 Karakter olmalıdır.")]
        public string Email { get; set; }
        [Required,StringLength(50,ErrorMessage ="%0 Karakter olmalıdır.")]
        public string Password { get; set; }
        public string Vis { get; set; }
    }
}