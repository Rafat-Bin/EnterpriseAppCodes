using Microsoft.EntityFrameworkCore;
using PracticeMovieLab.Core.Data;
using PracticeMovieLab.Core.Models;

namespace PracticeMovieLab.Core.Services
{
    public class MovieService
    {
        private readonly AppDbContext _db;

        public MovieService(AppDbContext db)
        {
            _db = db;
        }

        // US1: Add persists and generates key (> 0)
        // Validation: if movie is null -> throw ArgumentNullException
        public async Task<int> AddMovieAsync(Movie movie)
        {
            if (movie is null)
                throw new ArgumentNullException(nameof(movie));

            _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();

            return movie.Id; // EF Core generates Id after SaveChanges
        }

        // US2: Delete removes the row
        // If id does not exist -> return false
        public async Task<bool> DeleteByIdAsync(int id)
        {
            var movie = await _db.Movies.FindAsync(id);
            if (movie is null)
                return false;

            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return true;
        }

        // US3: Return movies where Rating < maxRating sorted by Rating ascending
        // Validation: if maxRating < 0 -> throw ArgumentOutOfRangeException
        public async Task<List<Movie>> GetUnderRatingAsync(decimal maxRating)
        {
            if (maxRating < 0)
                throw new ArgumentOutOfRangeException(nameof(maxRating));

            return await _db.Movies
                .AsNoTracking()
                .Where(m => m.Rating < maxRating)
                .OrderBy(m => m.Rating)
                .ToListAsync();
        }
    }
}
