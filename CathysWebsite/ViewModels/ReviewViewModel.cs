using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CathysWebsite.ViewModels
{
    public class ReviewViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateWritten { get; set; }

        public HttpPostedFileBase Image { get; set; }

        public string Link { get; set; }
    }
}