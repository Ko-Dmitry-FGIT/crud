using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class MovieVMList
    {
        private MovieVM _selectedMovie;
        public MovieVMList()
        {
            MovieList = new List<MovieVM>();
            DataProvider DataProvider = new DataProvider();
            List<Movie> movieList = DataProvider.GetMovieList();
            foreach (Movie c in movieList)
            {
                MovieList.Add(new MovieVM(c));
            }
            DataProvider.CloseConnection();
        }
        public List<MovieVM> MovieList
        {
            get; set;
        }
        public MovieVM SelectedMovie
        {
            get
            {
                return _selectedMovie;
            }
            set
            {
                _selectedMovie = value;
            }
        }
    }
}
