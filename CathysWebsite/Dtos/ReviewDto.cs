using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CathysWebsite.Dtos
{
    public class ReviewDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateWritten { get; set; }

        public DateTime DateAdded { get; set; }

        public string Imagepath { get; set; }

        public string Link { get; set; }
    }
}