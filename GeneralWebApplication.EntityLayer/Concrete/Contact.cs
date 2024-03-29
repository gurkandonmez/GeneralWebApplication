﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mail { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}
