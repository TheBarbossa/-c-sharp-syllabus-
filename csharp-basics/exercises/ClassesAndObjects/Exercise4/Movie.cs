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
        private string _title;
        private string _studio;
        private string _rating;
        List<string> Movies = new List<string>();
        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
            Movies.Add($"{title}, {studio}, {rating}");
        }
        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }
        
        public void GetPG()
        {
            foreach (string movie in Movies)
            {
                if (!(movie.Contains("PG13")))
                    Console.WriteLine(movie);
            }
        }
    }
}
