# Practice Lab: LINQ Query Service + xUnit (Practice)

## Scenario: Student Course Management System

You are building a query service for a system that manages students and their course enrollments.  
Your goal is to implement **pure LINQ queries** and write **unit tests** that verify the behavior.

---

## Where You Are Supposed to Make Changes

You will be working in two main places:

###  Domain Layer (Implementation)
**File:** `Student.Domain/StudentQueryService.cs`  
 Implement all query methods using LINQ:
- `GetActiveStudents`
- `SortByGpaDescending`
- `ProjectForHonorRoll`


>  Do NOT modify the `Student` model.

---

###  Test Layer (Unit Tests)
**File:** `Student.Tests/StudentQueryServiceTests.cs`  
 Complete the `TODO` assertions inside each test.

You will:
- Write assertions that match the behavioral requirements
- Use Arrange → Act → Assert pattern
- Verify both correct results and exception handling

---

## Repo Structure (Suggested)

```
PracticeLab/
 ├─ Student.Domain/
 │   ├─ Student.cs
 │   └─ StudentQueryService.cs
 ├─ Student.Tests/
 │   └─ StudentQueryServiceTests.cs
 └─ PracticeLab.sln
```

---

# Domain Model 

## `Student.cs`
```csharp
namespace PracticeLab.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsActive { get; set; }
        public double GPA { get; set; }
        public string Major { get; set; } = "";
    }
}
```

---

# Starter Service 

## `StudentQueryService.cs`
```csharp
using System;
using System.Collections.Generic;

namespace PracticeLab.Domain
{
    public class StudentQueryService
    {
        public IEnumerable<Student> GetActiveStudents(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> SortByGpaDescending(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<(string Name, double GPA)> ProjectForHonorRoll(IEnumerable<Student> students)
        {
            throw new NotImplementedException();
        }

       
    }
}
```

---

# Core Behavioral Requirements 

## 1 – Filter Active Students
**Given** a collection of students  
**When** filtering active students  
**Then** only students where `IsActive == true` are returned  

---

## 2 – Sort by GPA (Descending)
**Given** a collection of students  
**When** sorting by GPA  
**Then** students are ordered from highest GPA to lowest  
**And** if GPA is the same, break ties by `Name` ascending  

---

## 3 – Projection for Honor Roll
**Given** a collection of students  
**When** projecting for honor roll  
**Then** only `(Name, GPA)` pairs are returned  

---

## 4 – Guard Rails
**Given** a null collection  
**When** passed to any query method  
**Then** an `ArgumentNullException` is thrown  

 

---

# Practice Test File Template (Complete TODOs)

## `StudentQueryServiceTests.cs`
```csharp
using PracticeLab.Domain;
using Xunit;

namespace PracticeLab.Tests
{
    public class StudentQueryServiceTests
    {
        private static List<Student> Seed() => new()
        {
            new() { Id=1, Name="Alice", IsActive=true,  GPA=3.9, Major="CS" },
            new() { Id=2, Name="Bob",   IsActive=false, GPA=2.5, Major="Math" },
            new() { Id=3, Name="Carol", IsActive=true,  GPA=3.9, Major="CS" },
            new() { Id=4, Name="Dan",   IsActive=true,  GPA=3.2, Major="Physics" }
        };

        private readonly StudentQueryService _service = new();

        [Fact]
        public void GetActiveStudents_ReturnsOnlyActiveStudents()
        {
            // Arrange
            var students = Seed();

            // Act
            var result = _service.GetActiveStudents(students);

            // Assert
            // TODO: Assert only active students returned
        }

        [Fact]
        public void SortByGpaDescending_SortsByGpaThenName()
        {
            // Arrange
            var students = Seed();

            // Act
            var result = _service.SortByGpaDescending(students);

            // Assert
            // TODO: Assert order: Alice, Carol, Dan, Bob
        }

        [Fact]
        public void ProjectForHonorRoll_ReturnsNameAndGpaPairs()
        {
            // Arrange
            var students = Seed();

            // Act
            var result = _service.ProjectForHonorRoll(students);

            // Assert
            // TODO: Assert projection shape and values
        }

        [Fact]
        public void GetActiveStudents_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<Student>? students = null;

            // Act & Assert
            // TODO: Assert exception
        }

        [Fact]
        public void SortByGpaDescending_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<Student>? students = null;

            // Act & Assert
            // TODO: Assert exception
        }

        [Fact]
        public void ProjectForHonorRoll_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IEnumerable<Student>? students = null;

            // Act & Assert
            // TODO: Assert exception
        }

     
    }
}
```

---

# Notes 

- Use **LINQ only** (no loops for core query logic)
- Do **not modify** the input collection
- Ensure **deterministic sorting** using `ThenBy`
- Follow the **Arrange → Act → Assert** testing pattern
- Demonstrate at least one **RED → GREEN** cycle using:

