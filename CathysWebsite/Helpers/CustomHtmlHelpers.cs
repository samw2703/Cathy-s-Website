using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CathysWebsite.Models; 

namespace CathysWebsite.Helpers
{
    public class CustomHtmlHelpers
    {
        public static string ReviewsListElement(Review review)
        {
            string result = "<li><h3>{0}</h3><div class=\"ReviewLinkContainer\"><img src=\"{1}\" /></div></li>";

            return result;
        }
    }
}