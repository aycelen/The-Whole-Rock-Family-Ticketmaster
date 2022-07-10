using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models.Model
{[Table("Category")]
    public class Category
    {
        [Key]

        public int CatId { get; set; }
        [Required,StringLength(50,ErrorMessage ="50 Karakter Olmalıdır.")]
        [DisplayName("Kategori Adı")]
        public string CatName { get; set; }
        [Required]
        [DisplayName("Kategori Açıklaması")]
        public string CatExp { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}