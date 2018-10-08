using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBox.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<Movie> Movie { get; set; }

    }
}