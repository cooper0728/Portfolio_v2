﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Models.CodeFirst
{
    public class Post
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        [Required]
        public string Title { get; set; }
        public string Body { get; set; }
        public string MediaUrl { get; set; }
        public bool Published { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
} 