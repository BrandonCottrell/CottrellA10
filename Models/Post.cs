﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTutorial_20024.Models
{
    public class Post
    {
        public int PostID { get; set; } 
        public string Title { get; set; }
        public string Content { get; set; }
        public int? BlogId { get; set; }

        //navigation properties
        public virtual Blog Blog { get; set; }
    }
}
