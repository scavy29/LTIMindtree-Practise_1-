using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogApp.Models;

namespace BlogApp.Controllers
{
    // [Route("[controller]")]
    public class PostController : Controller
    {
        PostDbContext db=new PostDbContext();
        public IActionResult Index()
        {
            var postlist=db.Posts;
            return View(postlist);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post p)
        {
            if(ModelState.IsValid)
            {
                db.Posts.Add(p);
                db.SaveChanges();
                ViewBag.Message="Post Added";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var pos=db.Posts.Find(id);
            if(pos!=null)
            {
                db.Remove(pos);
                db.SaveChanges();
                Console.WriteLine("Deleted Post");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var po=db.Posts.Find(id);
            if(po!=null)
            {
                return View(po);
            }
            else{
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Post p)
        {
            db.Update(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var listofpost=db.Posts.Find(id);
            return View(listofpost);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}