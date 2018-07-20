using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Harry Potter";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Harry Potter is a wizzard abc xyz </p>";
            ViewBag.Artists = new string[] {
                "Harry",
                "Hermionie",
                "Ron"
    };
            return View();
        }
    }
}
