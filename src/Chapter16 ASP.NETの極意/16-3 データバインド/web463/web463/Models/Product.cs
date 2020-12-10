using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web463.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0}�͕K�{���ڂł�")]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
