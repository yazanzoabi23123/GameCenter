using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class7
{
    internal  class Movie
    {
        public int id;
        public string title;
        public string director;
        public int releaseYear;
         public Movie(int id, string title, string director, int releaseYear)
        {
            this.id = id;
            this.title = title;
            this.director = director;
            this.releaseYear = releaseYear;
        }
        public Movie() { }
    }
}
