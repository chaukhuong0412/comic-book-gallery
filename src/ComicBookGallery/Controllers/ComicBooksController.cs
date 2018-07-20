using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "Harry Potter",
                IssueNumber = 700,
                DescriptionHtml = "<p>Harry Potter is a wizzard abc xyz </p>",
                Artists = new Artist[] {
                new Artist() { Name = "Daniel", Role = "Harry"},
                new Artist() { Name = "Emma", Role = "Herminone"},
                new Artist() { Name = "Robert", Role = "Ron"}
                }
            };

            
            return View(comicBook);
        }
    }
}
