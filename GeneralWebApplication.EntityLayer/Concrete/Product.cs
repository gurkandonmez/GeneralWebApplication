using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public string Image { get; set; }

        public bool Status { get; set; }
        public DateTime Date { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory Category { get; set; }

    }
}
