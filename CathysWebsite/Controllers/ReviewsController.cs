using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CathysWebsite.Models;

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            review.DateAdded = DateTime.Now;
            _context.Reviews.Add(review);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}