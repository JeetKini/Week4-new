using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlysProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MovieGenre Genre { get; set; }


        public DateTime ReleaseDate { get; set; }
        public DateTime DataAdded { get; set; } 
        public int NumberInStock { get; set; }
    }
}