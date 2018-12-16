using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Videoverwaltung.Resources
{
    public class Genre
    {
        
        public Genre ()
        {
            this.movies = new List<Movie>();
        }

        public Genre (string genrePath)
        {
            this.GenreName = Path.GetFileName(genrePath);
            this.movies = new List<Movie>();
            this.genrePath = genrePath;
            Movie movie = null;
            foreach(string moviedir in Directory.EnumerateDirectories(genrePath))
            {
                movie = new Movie(moviedir);
                this.movies.Add(movie);
            }
        }


        public string GenreName { get; set; }
        public string genrePath { get; set; }


        private List<Movie> movies;
        public List<Movie> Movies
        {
            get { return movies; }
            set { movies = value; }
        }


    }

    
}
