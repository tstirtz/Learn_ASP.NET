using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learn_ASP.NET.Models;

namespace Learn_ASP.NET.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Index()
        {
            var model = 
                from b in _books
                orderby b.Title
                select b;

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

        static List<Book> _books = new List<Book>
        {
            new Book{
                Id = 1,
                Title = "Ender's Game",
                Author = "Orson Scott Card",
                Rating = 9,
            },
            new Book{
                Id = 2,
                Title = "The Martian",
                Author = "Andy Weir",
                Rating = 8,
            },
            new Book{
                Id = 3,
                Title = "Creativity Inc",
                Author = "Ed Catmull",
                Rating = 8,
            },
            new Book{
                Id = 4,
                Title = "The Davinci Code",
                Author = "Dan Brown",
                Rating = 9,
            },
            new Book{
                Id = 5,
                Title = "Blink",
                Author = "Malcolm Gladwell",
                Rating = 8
            }
        };
    }
}