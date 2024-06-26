﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAnCoSo.Models.EF
{
    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên danh mục không để trống")]
        [StringLength(150)]
        public string Title { get; set; }
        //public string TypeCode { get; set; }
        //[StringLength(150)]
        //public string Link { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        [StringLength(150)]

        public string SeoTitle { get; set; }
        [StringLength(250)]

        public string SeoDescription { get; set; }
        [StringLength(150)]

        public string SeoKeywords { get; set; }

        public bool IsActive { get; set; }


        public int Position { get; set; }

    }
}