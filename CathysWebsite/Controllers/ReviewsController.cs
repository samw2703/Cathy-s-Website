using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using CathysWebsite.Models;
using CathysWebsite.ViewModels;
using static System.Drawing.Image;

namespace CathysWebsite.Controllers
{
    public class ReviewsController : Controller
    {
        private ApplicationDbContext _context;

        public ReviewsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Review
        public ActionResult Index()
        {
            List<Review> reviews = _context.Reviews.ToList();

            return View(reviews);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create(ReviewViewModel viewModel)
        {
            var imageByteArray = ConvertImageToByteArray(viewModel.Image);           
            var review = new Review
            {
                DateAdded = DateTime.Now,
                DateWritten = viewModel.DateWritten,
                Description = viewModel.Description,
                Image = imageByteArray,
                Title = viewModel.Title,
                Link = viewModel.Link
            };
            _context.Reviews.Add(review);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

        private byte[] ConvertImageToByteArray(HttpPostedFileBase file)
        {
            if (file == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                file.InputStream.CopyTo(ms);
                byte[] array = ms.GetBuffer();

                return array;
            }
        }
    }
}