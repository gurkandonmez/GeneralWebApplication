using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class ArticleCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public bool Status { get; set; }


    }
}
