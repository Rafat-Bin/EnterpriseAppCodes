# Practice Activity -- EF Core Service 

------------------------------------------------------------------------

## Important Instructions (Read Carefully)

-   **Everything in this project is already provided.**
-   You will **ONLY write code inside one file:**


    PracticeMovieLab.Core/Services/MovieService.cs

Do NOT modify: - Models - DbContext - Tests - Helper classes -
Project files

Only implement the required method behaviors inside
`MovieService.cs`.

------------------------------------------------------------------------

## How Your Code Will Be Evaluated

-   The project already includes **unit tests**.
-   These tests automatically verify your service logic.
-   You do NOT write tests.
-   You ONLY run the tests.

### Red vs Green Tests

-    Red = Your implementation is incorrect or incomplete\
-    Green = Your implementation is correct

Your goal is to make **all tests pass (green)**.

Run tests using:

Visual Studio Test Explorer.

------------------------------------------------------------------------

## Goal

Practice EF Core persistence behavior in a service layer using SQLite
in-memory tests and a helper class (same style as Lab04 but simplified).

------------------------------------------------------------------------

## Repo Structure (Provided)

    PracticeMovieLab/
     ├─ PracticeMovieLab.Core/      (Domain + EF Core + service)
     │  ├─ Models/Movie.cs
     │  ├─ Data/AppDbContext.cs
     │  └─ Services/MovieService.cs   <-- ONLY FILE YOU EDIT
     ├─ PracticeMovieLab.Tests/     (xUnit tests + SQLite helper)
     │  ├─ MovieServiceTests.cs
     │  └─ DbTestHelper.cs
     └─ PracticeMovieLab.slnx

> Again: **You will only modify `MovieService.cs`. Everything else is
> provided and must remain unchanged.**

------------------------------------------------------------------------

# Core Behaviors to Implement

## US1 -- Add Persists and Generates Key

**Given** a valid Movie\
**When** `AddMovieAsync(movie)` is called\
**Then** - Returns generated Id (\> 0) - Movie is persisted and can be
retrieved using a new DbContext

Validation: - If movie is `null` → throw `ArgumentNullException`

------------------------------------------------------------------------

## US2 -- Delete Removes the Row

**Given** an existing movie Id\
**When** `DeleteByIdAsync(id)` is called\
**Then** - Movie is removed from database - A new DbContext cannot find
the movie

If the Id does not exist → return `false`

------------------------------------------------------------------------

## US3 -- Get Movies Under Rating

**Given** seeded movies\
**When** `GetUnderRatingAsync(maxRating)` is called\
**Then** - Return movies where `Rating < maxRating` - Results sorted by
`Rating` ascending

Validation: - If `maxRating` is negative → throw
`ArgumentOutOfRangeException`

------------------------------------------------------------------------

# Validation Rules (Service Layer Only)

All validation must be inside the service layer: - Null movie →
`ArgumentNullException` - Negative maxRating →
`ArgumentOutOfRangeException`

------------------------------------------------------------------------

# SQLite Test Behavior

The provided tests use a **SQLite in-memory database** through
`DbTestHelper`.\
The helper keeps a connection open so the database persists across
multiple DbContext instances within each test.

This allows tests to verify true EF Core persistence behavior.

------------------------------------------------------------------------

# Starter Code -- MovieService.cs

Below is the starter code already included in the project.\
You must implement the required behaviors **only inside this file**.

Do not modify method signatures.\
Do not change anything outside this file.

``` csharp
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
        public Task<int> AddMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        // US2: Delete removes the row
        // If id does not exist -> return false
        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        // US3: Return movies where Rating < maxRating sorted by Rating ascending
        // Validation: if maxRating < 0 -> throw ArgumentOutOfRangeException
        public Task<List<Movie>> GetUnderRatingAsync(decimal maxRating)
        {
            throw new NotImplementedException();
        }
    }
}
```

------------------------------------------------------------------------

# Workflow

Run tests using:

Visual Studio Test Explorer.



------------------------------------------------------------------------

# Reminder

-   Do NOT change any provided files
-   Do NOT edit tests
-   Only write code inside `MovieService.cs`
-   Your solution is correct only when **all unit tests pass**


