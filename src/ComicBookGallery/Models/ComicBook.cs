using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { set; get; }
        public string SeriesTitle { set; get; }
        public int IssueNumber { set; get; }
        public string Description { set; get; }
        public Artist[] Artists { set; get; }
        public bool Favorite { set; get; }

        public string DisplayText => SeriesTitle + " #" + IssueNumber;
        public string CoverImageFileName => SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
    }
}