using MovieBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBox.ViewModels
{
    public class SortMovieViewModel : LayoutViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movielist { get; set; }
    }
}