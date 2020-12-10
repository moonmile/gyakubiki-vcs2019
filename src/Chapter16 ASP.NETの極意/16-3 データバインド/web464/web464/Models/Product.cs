using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace web464.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(100, 1000, ErrorMessage = "{0}��{1}����{2}�܂ł̊ԂŎw�肵�Ă�������")]
        public int Price { get; set; }
    }
}
