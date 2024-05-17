using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using NordicMagaza.Models;
using System.Diagnostics;

namespace NordicMagaza.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var posts = getAllPosts();
            ViewData["Title"] = "Ana Sayfa";
            return View(posts);
        }
        public List<Store> getAllPosts()
        {
            var posts = new List<Store>();
            using StreamReader reader = new StreamReader("AppData/posts/index.txt");
            var postsTxt = reader.ReadToEnd();
            var postsLines = postsTxt.Split('\n');
            foreach (var postLine in postsLines)
            {
                var postParts = postLine.Split('|');
                posts.Add(
                    new Store()
                    {
                        Title = postParts[0],
                        Summary = postParts[1],
                        Content = postParts[2],
                        ImgUrl = postParts[3],
                        Slug = postParts[4]
                    }
                );
            }
            return posts;
        }
    }
}
