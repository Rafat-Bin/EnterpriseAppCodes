using System;
using System.Collections.Generic;
using System.Text;

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

        // US1: Add persists and generates key (>0)
        // Validation: if movie is null -> throw ArgumentNullException
        public Task<int> AddMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        // US2: Delete removes the row
        // If id not found -> return false
        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // US3: Get movies where Rating < maxRating sorted by Rating asc
        // Validation: if maxRating < 0 -> throw ArgumentOutOfRangeException
        public Task<List<Movie>> GetUnderRatingAsync(decimal maxRating)
        {
            throw new NotImplementedException();
        }
    }
}