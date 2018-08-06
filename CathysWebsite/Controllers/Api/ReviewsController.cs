using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CathysWebsite.Models;
using CathysWebsite.Dtos;
using AutoMapper;


namespace CathysWebsite.Controllers.Api
{
    public class ReviewsController : ApiController
    {
        private ApplicationDbContext _context;

        public ReviewsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/Reviews
        public IHttpActionResult GetReviews()
        {
            IEnumerable<Review> reviewsQuery = _context.Reviews;

            IEnumerable<ReviewDto> reviewDtos = reviewsQuery
                .ToList()
                .Select(Mapper.Map<Review, ReviewDto>);

            return Ok(reviewDtos);
        }
    }
}
