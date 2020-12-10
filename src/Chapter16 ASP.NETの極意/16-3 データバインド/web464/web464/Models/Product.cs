using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web464.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(100, 1000, ErrorMessage = "{0}は{1}から{2}までの間で指定してください")]
        public int Price { get; set; }
    }
}
