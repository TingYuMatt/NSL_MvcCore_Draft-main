﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Nsl_Core.Models.EFModels
{
    public partial class Articles
    {
        public Articles()
        {
            ArticlesClick = new HashSet<ArticlesClick>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string ArticleContent { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<ArticlesClick> ArticlesClick { get; set; }
    }
}