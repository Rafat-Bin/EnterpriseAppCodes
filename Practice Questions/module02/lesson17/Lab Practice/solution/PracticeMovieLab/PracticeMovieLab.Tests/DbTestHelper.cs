using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PracticeMovieLab.Core.Data;

namespace PracticeMovieLab.Tests
{
    public static class DbTestHelper
    {
        /// <summary>
        /// Creates and opens a SQLite in-memory connection. Keep this connection OPEN
        /// for the entire test to ensure the in-memory database persists across DbContexts.
        /// </summary>
        public static SqliteConnection CreateOpenInMemoryConnection()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            return connection;
        }

        public static DbContextOptions<AppDbContext> CreateOptions(SqliteConnection connection)
        {
            return new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite(connection)
                .Options;
        }

        public static AppDbContext CreateContext(DbContextOptions<AppDbContext> options, bool ensureCreated = false)
        {
            var context = new AppDbContext(options);

            if (ensureCreated)
                context.Database.EnsureCreated();

            return context;
        }
    }
}