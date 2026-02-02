#  Person Class – OOP & xUnit Guided Exercise

##  Overview

This exercise focuses on designing a **robust domain model** using **object-oriented principles** in C# and validating its behavior through **unit testing with xUnit**.

You will implement a `Person` class that always exists in a **valid state** and write unit tests to verify both **valid and invalid input scenarios**.

---

##  Learning Objectives

By completing this exercise, you will:

- Apply **encapsulation** using private fields and public properties
- Enforce **constructor validation**
- Throw appropriate exceptions for invalid data
- Create **read-only computed properties**
- Write **unit tests using xUnit**
- Separate **domain logic** from **test logic**

---

##  Problem Statement

Design and implement a `Person` class in C# using object-oriented principles and unit testing with xUnit.

The `Person` class must represent a person with a first name, last name, and email address. A `Person` object must always be created in a valid state.

### Class Requirements

- A `Person` must be created using a constructor that requires:
  - First name
  - Last name
  - Email
- `FirstName` and `LastName`:
  - Are required
  - Must not be `null`, empty, or whitespace
  - Must throw an `ArgumentNullException` if invalid
- `Email`:
  - Stored as a simple string
  - No validation rules required
- The class must expose a **read-only** `FullName` property that returns:

```
LastName, FirstName
```

- Data must be encapsulated using **private fields** and **public properties**

---

##  Unit Testing Requirements (xUnit)

Write unit tests to verify:

- A `Person` object is created correctly with valid input
- Exceptions are thrown when invalid first or last names are provided
- The `FullName` property returns the expected formatted value

---

##  Project Structure

```
Solution
│
├── Domain.Core
│   └── Person_Guided.cs
│
└── Domain.Tests
    └── PersonTests_Guided.cs
```

---

##  Guided Domain File

**File:** `Person_Guided.cs`

```csharp


namespace Domain
{
    // Person_Guided.cs
    // Guided exercise: Practice object-oriented design with constructor validation.

    // =====================================================
    // TODO: Create a Person class
    // =====================================================
    // Requirements:
    // - Use private fields for first name, last name, and email
    // - Create a constructor that requires first name, last name, and email
    // - FirstName and LastName must NOT be null, empty, or whitespace
    // - Throw ArgumentNullException if invalid values are provided
    // - Email should be stored as a simple string (no validation)
    // - Expose public properties for FirstName, LastName, and Email
    // - Add a read-only FullName property that returns:
    //   "LastName, FirstName"


    // TODO: Define the Person class below



}
```

---

##  Guided Test File

**File:** `PersonTests_Guided.cs`

```csharp

using Xunit;
using Domain;

namespace Domain.Tests
{
    // PersonTests_Guided.cs
    // Guided exercise: Write unit tests for the Person class using xUnit.

    public class PersonTests_Guided
    {
        // TODO: Write a test to verify:
        // - A Person object is created correctly with valid input
        // - FirstName, LastName, and Email are set properly


        // TODO: Write a [Theory] test with [InlineData]
        // - Pass null, empty, and whitespace values
        // - Verify ArgumentNullException is thrown for invalid FirstName


        // TODO: Write a [Theory] test with [InlineData]
        // - Pass null, empty, and whitespace values
        // - Verify ArgumentNullException is thrown for invalid LastName


        // TODO: Write a test to verify:
        // - FullName returns "LastName, FirstName"
    }
}
```

---

##  Completion Criteria

You are finished when:

- All TODOs are implemented
- All unit tests pass
- Invalid data cannot create an invalid `Person`
- Code follows clean OOP principles

---

## Notes

- This project is a **.NET Class Library**
- There should be **no `Main()` method**
- Unit tests act as the executable validation of your code
