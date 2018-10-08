using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBox.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public string Details { get; set; }


        public List<Movie> GetmoviesByInput(string input)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var movie = context.Movies.Where(c => c.Name.Contains(input)).ToList();

            return movie;
        }


    }
}