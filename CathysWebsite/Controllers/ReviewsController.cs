using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
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
            var review = new Review
            {
                DateAdded = DateTime.Now,
                DateWritten = viewModel.DateWritten,
                Description = viewModel.Description,
                Image = CreateImageRecord(viewModel.ImagePath),
                Title = viewModel.Title,
                Link = viewModel.Link
            };
            _context.Reviews.Add(review);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private byte[] CreateImageRecord(string imageFilePath)
        {
            var image = Image.FromFile(imageFilePath);
            MemoryStream stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return stream.ToArray();
        }
    }
}