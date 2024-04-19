using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAnCoSo.Models.EF
{
    [Table("tb_Product")]
    public class Product : CommonAbstract
    {
        public Product() 
        {
            this.ProductImage = new HashSet<ProductImage>();
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
        public int ProductCategoryID { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set;}
        public string SeoKeywords { get; set; } 

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }


    }
}