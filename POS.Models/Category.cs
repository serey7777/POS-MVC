﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace POS.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
       
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(30)]
        public string? Name { get; set; }

       
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
