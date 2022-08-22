using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class ProductImage
    {
        public int Id { get; set; } 
        public string Image { get; set; }
        
        public int ProductId { get; set; }

        Product Product { get; set; }
    }
}
