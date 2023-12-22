using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlysProject.Models;

namespace VidlysProject.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<MovieGenre> movieGenres { get; set; }
        public Movie Movie { get; set; }

    }
}