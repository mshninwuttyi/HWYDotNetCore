﻿using System.Text;
using System.Text.Json.Serialization;
using HWYDotNetCore.MvcApiCall;
using HWYDotNetCore.MvcApiCall.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using static System.Net.Mime.MediaTypeNames;

namespace HWYDotNetCore.MvcApiCall.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogApi _blogApi;

        public BlogController(IBlogApi blogApi)
        {
            _blogApi = blogApi;
        }

        [ActionName("Index")]
        public async Task<IActionResult> BlogIndexAsync(int pageNo = 1, int pageSize = 10)
        {
            var model = await _blogApi.GetBlogs(pageNo, pageSize);
            return View("BlogIndex", model);
        }

        [ActionName("Create")]
        public IActionResult BlogCreate()
        {
            return View("BlogCreate");
        }

        [HttpPost]
        [ActionName("Save")]
        public async Task<IActionResult> BlogSave(BlogModel blog)
        {
            await _blogApi.CreateBlog(blog);
            return Redirect("/Blog");
        }

        [ActionName("Edit")]
        public async Task<IActionResult> BlogEditAsync(int id)
        {
            var model = await _blogApi.GetBlog(id);
            return View("BlogEdit", model);
        }

        [ActionName("Update")]
        public async Task<IActionResult> BlogUpdate(int id, BlogModel blog)
        {
            await _blogApi.UpdateBlog(id, blog);
            return Redirect("/Blog");
        }

        [ActionName("Delete")]
        public async Task<IActionResult> BlogDelete(int id)
        {
            await _blogApi.DeleteBlog(id);
            return Redirect("/Blog");
        }
    }
}
