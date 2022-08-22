﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralWebApplication.EntityLayer.Concrete
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string Thumbnail { get; set; }

        public string Image { get; set; }

        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        
        public int ArticleCategoryId { get; set; }  
        public ArticleCategory ArticleCategory { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
