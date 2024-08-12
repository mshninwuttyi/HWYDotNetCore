﻿using System.ComponentModel.DataAnnotations;

namespace HWYDotNetCore.MvcApiCall.Models
{
    public class BlogResponseModel
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public bool IsEndOfPage => PageNo == PageCount;
        public List<BlogModel> Data { get; set; }
    }

    public class BlogModel
    {
        [Key]
        public int BlogId { get; set; }
        public string? BlogTitle { get; set; }
        public string? BlogAuthor { get; set; }
        public string? BlogContent { get; set; }
    }
}
