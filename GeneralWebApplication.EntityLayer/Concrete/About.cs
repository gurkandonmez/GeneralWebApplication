using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }

        public string Vision { get; set; }

        public string Mission { get; set; }

        public string Image { get; set; }
        
        public string Map { get; set; }
        public bool Status { get; set; }


    }
}
