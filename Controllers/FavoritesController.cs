using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learn_ASP.NET.Models;

namespace Learn_ASP.NET.Controllers
{
    public class FavoritesController : Controller
    {
        public ActionResult Index()
        {
            var model = 
                from f in _favorites
                orderby f.Id
                select f;
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        static List<Favorite> _favorites = new List<Favorite>
        {
            new Favorite{
                Id = 1,
                Name = "Star Wars vs. Star Trek",
                Percent = 100,
                Description = "Do, or do not. There is no try.",
                Source = "Content/yoda.png"
            },
            new Favorite{
                Id = 2,
                Name = "Dog person vs. Cat Person",
                Percent = 60,
                Description = "Slightly more of a dog person. Although I have a cat named Kona!",
                Source = "Content/cat-and-dog.png"
            },
            new Favorite{
                Id = 3,
                Name = "Early Bird vs. Night Owl",
                Percent = 100,
                Description = "Definitely a night owl.",
                Source = "Content/owl.jpg"
            },
            new Favorite{
                Id = 4,
                Name = "Iphone vs. Android",
                Percent = 51,
                Description = "I recently crossed the line over to android",
                Source = "Content/android-icon.png"
            },
            new Favorite{
                Id = 5,
                Name = "Soda vs. La Croix",
                Percent = 100,
                Description = "Soda",
                Source = "Content/cola.png"
            },
            new Favorite {
                Id = 6,
                Name = "ASP.NET MVC vs. Web Forms",
                Percent = 50,
                Description = "I am really enjoying working with ASP.NET MVC and I'm excited to begin digging into Web Forms!",
                Source = "Content/microsoft.png"
            }
        };
    }
}