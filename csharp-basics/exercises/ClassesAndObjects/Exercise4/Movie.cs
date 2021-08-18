using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise4
{
    class Movie
    {
        List<string> Movies = new List<string>();
        public Movie(string title, string studio, string rating)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
            Movies.Add($"{title}, {studio}, {rating}");
        }
        public Movie(string title, string studio)
        {
            Title = title;
            Studio = studio;
            Rating = "PG";
        }
        private string Title;
        private string Studio;
        private string Rating;
        public void getPG()
        {
            foreach (string movie in Movies)
            {
                if (!(movie.Contains("PG13")))
                    Console.WriteLine(movie);
                    
            }
        }

    }
}
