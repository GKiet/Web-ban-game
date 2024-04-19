using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnCoSo.Models.EF
{
    [Table("tb_ProductCategory")]
    public class ProductCategory : CommonAbstract
    {
        public ProductCategory() { 
            this.Products = new HashSet<Product>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Alias { get; set; }
        public string Description { get; set; }
        [StringLength(200)]

        public string Icon { get; set; }
        [StringLength(200)]

        public string SeoTitle { get; set; }
        [StringLength(300)]

        public string SeoDescription { get; set; }
        [StringLength(200)]

        public string SeoKeywords { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}