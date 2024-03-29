﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    

        public string userName { get; set; }

        public string Password { get; set; }
        public string About { get; set; }   

        public string Image { get; set; }

        public string Mail { get; set; }
        public bool Status { get; set; }

    }
}
