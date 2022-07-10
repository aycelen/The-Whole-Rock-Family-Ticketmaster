using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace THRF.Models.Model
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [Required]
        [DisplayName(" Blog Başlığı")]
        public string BlogHead { get; set; }
        [Required]
        [DisplayName("Blog Açıklaması ")]
        public string BlogCont { get; set; }
        [Required]
        [DisplayName("Bağlı olduğu Kategori Id'si ")]
        public int? CatId { get; set; }
        public Category Category { get; set; }
    }
}