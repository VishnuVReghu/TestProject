using HomeCinema.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCinema.Web.Mappings
{
    public static class OmdbMovieMapper
    {

        public static IEnumerable<MovieViewModel> MapPocoToRepoAll(RootObject modelSource)
        {
            var listMovieRepoData = new List<MovieViewModel>();

            MovieViewModel movieDestData;

            foreach (var srcData in modelSource.Search)
            {
                movieDestData = new MovieViewModel();
                movieDestData.Title = srcData.Title;
                movieDestData.ReleaseDate = Convert.ToDateTime(srcData.ReleaseDate);
                movieDestData.Director = srcData.Director;
                movieDestData.Description = srcData.Description;
                movieDestData.Image = srcData.Poster;
                
                listMovieRepoData.Add(movieDestData);
            }

            return listMovieRepoData;
        }
    }
}