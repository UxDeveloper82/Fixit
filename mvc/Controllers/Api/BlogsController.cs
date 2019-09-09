using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvc.Controllers.Api
{
    public class BlogsController : ApiController
    {
        private ApplicationDbContext _context;

        public BlogsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/blogs
        public IEnumerable<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }
        //GET /api/blogs/1
        public Blog GetBlog(int id)
        {
            var blog = _context.Blogs.SingleOrDefault(b => b.Id == id);

            if (blog == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return blog;
        }

        //POST /api/blogs
        [HttpPost]
        public Blog CreateBlog(Blog blog)
        {
            if (ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return blog;
        }

        //PUT /api/blogs/1
        [HttpPut]
        public void UpdateBlog(int id, Blog blog)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var blogInDb = _context.Blogs.SingleOrDefault(b => b.Id == id);

            if (blogInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            blogInDb.Title = blog.Title;
            blogInDb.Description = blog.Description;
            blogInDb.TimePosted = blog.TimePosted;

            _context.SaveChanges();

        }

        //Delete /api/blogs/1
        [HttpDelete]
        public void DeleteBlog(int id)
        {
            var blogInDb = _context.Blogs.SingleOrDefault(b => b.Id == id);
            if(blogInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Blogs.Remove(blogInDb);
            _context.SaveChanges();
        }
    }
}


