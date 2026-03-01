using System;
using System.Collections.Generic;
using System.Text;

using PracticeMovieLab.Core.Data;
using PracticeMovieLab.Core.Models;
using PracticeMovieLab.Core.Services;

namespace PracticeMovieLab.Tests
{
    public class MovieServiceTests
    {
        private static async Task<int> SeedMovieAsync(AppDbContext db, string title, decimal rating, int copies)
        {
            var movie = new Movie { Title = title, Rating = rating, CopiesAvailable = copies };
            db.Movies.Add(movie);
            await db.SaveChangesAsync();
            return movie.Id;
        }

        private static async Task SeedManyAsync(AppDbContext db)
        {
            await SeedMovieAsync(db, "A Movie", 7.2m, 3);
            await SeedMovieAsync(db, "B Movie", 5.0m, 1);
            await SeedMovieAsync(db, "C Movie", 8.9m, 2);
            await SeedMovieAsync(db, "D Movie", 5.5m, 0);
        }

        [Fact]
        public async Task AddMovieAsync_WhenMovieIsNull_ThrowsArgumentNullException()
        {
            using var conn = DbTestHelper.CreateOpenInMemoryConnection();
            var options = DbTestHelper.CreateOptions(conn);

            using var db = DbTestHelper.CreateContext(options, ensureCreated: true);
            var service = new MovieService(db);

            await Assert.ThrowsAsync<ArgumentNullException>(() => service.AddMovieAsync(null!));
        }

        [Fact]
        public async Task AddMovieAsync_WhenValidMovieProvided_ReturnsGeneratedIdAndPersists()
        {
            using var conn = DbTestHelper.CreateOpenInMemoryConnection();
            var options = DbTestHelper.CreateOptions(conn);

            int id;
            using (var db1 = DbTestHelper.CreateContext(options, ensureCreated: true))
            {
                var service = new MovieService(db1);

                var movie = new Movie { Title = "Interstellar", Rating = 8.6m, CopiesAvailable = 2 };
                id = await service.AddMovieAsync(movie);

                Assert.True(id > 0);
            }

            // Verify using a NEW DbContext (persistence check)
            using (var db2 = DbTestHelper.CreateContext(options))
            {
                var saved = await db2.Movies.FindAsync(id);
                Assert.NotNull(saved);
                Assert.Equal("Interstellar", saved!.Title);
                Assert.Equal(8.6m, saved.Rating);
                Assert.Equal(2, saved.CopiesAvailable);
            }
        }

        [Fact]
        public async Task DeleteByIdAsync_WhenIdExists_RemovesRowAndPersists()
        {
            using var conn = DbTestHelper.CreateOpenInMemoryConnection();
            var options = DbTestHelper.CreateOptions(conn);

            int id;
            using (var db1 = DbTestHelper.CreateContext(options, ensureCreated: true))
            {
                id = await SeedMovieAsync(db1, "Delete Me", 6.1m, 1);
            }

            bool deleted;
            using (var db2 = DbTestHelper.CreateContext(options))
            {
                var service = new MovieService(db2);
                deleted = await service.DeleteByIdAsync(id);
                Assert.True(deleted);
            }

            using (var db3 = DbTestHelper.CreateContext(options))
            {
                var shouldBeGone = await db3.Movies.FindAsync(id);
                Assert.Null(shouldBeGone);
            }
        }

        [Fact]
        public async Task DeleteByIdAsync_WhenIdDoesNotExist_ReturnsFalse()
        {
            using var conn = DbTestHelper.CreateOpenInMemoryConnection();
            var options = DbTestHelper.CreateOptions(conn);

            using var db = DbTestHelper.CreateContext(options, ensureCreated: true);
            var service = new MovieService(db);

            var result = await service.DeleteByIdAsync(id: 999);

            Assert.False(result);
        }

        [Fact]
        public async Task GetUnderRatingAsync_WhenMaxRatingIsNegative_ThrowsArgumentOutOfRangeException()
        {
            using var conn = DbTestHelper.CreateOpenInMemoryConnection();
            var options = DbTestHelper.CreateOptions(conn);

            using var db = DbTestHelper.CreateContext(options, ensureCreated: true);
            var service = new MovieService(db);

            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => service.GetUnderRatingAsync(-1m));
        }

        [Fact]
        public async Task GetUnderRatingAsync_FiltersAndSortsByRatingAscending()
        {
            using var conn = DbTestHelper.CreateOpenInMemoryConnection();
            var options = DbTestHelper.CreateOptions(conn);

            using (var db1 = DbTestHelper.CreateContext(options, ensureCreated: true))
            {
                await SeedManyAsync(db1);
            }

            using var db2 = DbTestHelper.CreateContext(options);
            var service = new MovieService(db2);

            var results = await service.GetUnderRatingAsync(6.0m);

            Assert.All(results, m => Assert.True(m.Rating < 6.0m));
            Assert.True(results.Count > 0);

            // sorted by Rating asc
            var sorted = results.OrderBy(m => m.Rating).Select(m => m.Id).ToList();
            Assert.Equal(sorted, results.Select(m => m.Id).ToList());
        }
    }
}
