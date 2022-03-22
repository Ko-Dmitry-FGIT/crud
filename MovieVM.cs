using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class MovieVM
    {
        private Movie _movie;
        public MovieVM(Movie movie)
        {
            _movie = movie;
        }
        public string Name
        {
            get
            {
                return _movie.Name;
            }
            set
            {
                _movie.Name = value;
            }
        }
    }
}
