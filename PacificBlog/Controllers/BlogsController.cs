using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PacificBlog.Models;

namespace PacificBlog.Controllers
{
    public class BlogsController : Controller
    {
        // GET: Blogs
        public BlogModel BlogPage()
        {
            BlogModel BlogDetails = new BlogModel();
            BlogDetails.BlogTitle = "Test Title";
            BlogDetails.Writer = "By Anonymous";
            BlogDetails.Content = "Test Content:";
            return BlogDetails;            
        }

        public ActionResult CreateBlog()
        {
            return View();
        }
    }
}