using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScriptForMovie
{
    public class UpdateLocalPathInDB
    {
        public static void Update()
        {
            try
            {
                using (var db = new MovieEntities())
                {
                    string folderpath = @"C:\Users\PrashMaya\Pictures\MovieRecommendation\{0}";
                    foreach (var poster in db.PosterInfoes)
                    {
                        var movieId = (from movie in db.Movies
                                       where poster.MovieId == movie.ID
                                       select movie.ImdbID).ToList();
                        var localpath = string.Format(folderpath, movieId.FirstOrDefault());
                        var imdbId = movieId.FirstOrDefault();
                        poster.ImdbID = imdbId;
                        db.SaveChanges();
                    }   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
