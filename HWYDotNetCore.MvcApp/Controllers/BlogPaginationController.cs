using HWYDotNetCore.MvcApp.Database;
using HWYDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HWYDotNetCore.MvcApp.Controllers
{
    public class BlogPaginationController : Controller
    {
        private readonly AppDbContext _db;

        public BlogPaginationController(AppDbContext db)
        {
            _db = db;
        }

        [ActionName("Index")]
        public IActionResult BlogIndex(int pageNo = 1, int pageSize = 10)
        {
            //AppDbContext db = new AppDbContext();
            int rowCount = _db.Blogs.Count();

            int pageCount = rowCount / pageSize;
            if (rowCount % pageSize > 0)
                pageCount++;

            if (pageNo > pageCount)
            {
                return Redirect("/Blog");
            }

            var lst = _db.Blogs.Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();

            BlogResponseModel model = new();
            model.Data = lst;
            model.PageSize = pageSize;
            model.PageNo = pageNo;
            model.PageCount = pageCount;
            return View("BlogIndex", model);
        }
    }
}
