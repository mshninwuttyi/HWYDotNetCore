﻿using HWYDotNetCore.RestApiWithNLayer.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HWYDotNetCore.RestApiWithNLayer.Features.Blog
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BL_Blog _bl_blog;

        public BlogController() { 
            _bl_blog = new BL_Blog();
        }

        [HttpGet]
        public IActionResult Read()
        {
            var lst = _bl_blog.GetBlogs();
            return Ok(lst);
        }

        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            var item = _bl_blog.GetBlog(id);
            if (item is null)
            {
                return NotFound("No data found");
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create(BlogModel blog)
        {
           
            var result = _bl_blog.CreateBlog(blog);
            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            return Ok(message);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, BlogModel blog)
        {
            var item = _bl_blog.GetBlog(id);
            if (item is null)
            {
                return NotFound("No data found");
            }
            var result = _bl_blog.UpdateBlog(id, blog);
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            return Ok(message);
        }

        [HttpPatch]
        public IActionResult Patch(int id, BlogModel blog)
        {
            var item = _bl_blog.GetBlog(id);
            if (item is null)
            {
                return NotFound("No data found");
            }
            var result = _bl_blog.PatchBlog(id, blog); 
            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            return Ok(message);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _bl_blog.GetBlog(id);
            if (item is null)
            {
                return NotFound("No data found");
            }

            var result = _bl_blog.DeleteBlog(id);
            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";

            return Ok(message);
        }
    }
}
