using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstProduct.Models
{
    public class ProductType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}