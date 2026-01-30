## Overview
In this practice question, you will apply object-oriented programming principles and unit testing techniques using C# and xUnit. You will implement a simple UserAccount domain class that enforces validation rules, tracks state, and exposes controlled behaviors. You will then write unit tests to verify both valid behavior and error handling using the Arrange–Act–Assert (AAA) pattern.

The core code models a basic user account system. Each UserAccount object represents an individual user with a username, an age, and a lock status. The class is responsible for ensuring that only valid data is accepted and that changes to the account’s state occur through well-defined methods. This design helps demonstrate how business rules can be enforced within a domain class and validated through automated unit tests.



## Step 1 – Implement the `UserAccount`(.NET class library project)

In this step, you will practice implementing a domain class by completing the UserAccount.cs  file according to the rules below.

### Requirements

- Use **encapsulation** (private setters and/or backing fields)
- Apply validation using **exceptions**
- Track whether the account is locked or unlocked

---

### Rules

#### Username
- Must not be `null`, empty, or whitespace
- Enforced in the constructor and `ChangeUsername()`
- Invalid values must throw `ArgumentException`

#### Age
- Must be **13 or older**
- Enforced in the constructor and `ChangeAge()`
- Invalid values must throw `ArgumentOutOfRangeException`

---

### Behaviors

- `LockAccount()` → locks the account
- `UnlockAccount()` → unlocks the account
- `ChangeUsername(string newUsername)` → updates username if valid
- `ChangeAge(int newAge)` → updates age if valid

---

##  Starter Code – `UserAccount.cs`

```csharp
namespace PracticeLab.Domain
{
    public class UserAccount
    {
        // TODO: Add properties
        // Suggested:
        // - public string Username { get; private set; }
        // - public int Age { get; private set; }
        // - public bool IsLocked { get; private set; }

        // TODO: Implement constructor
        // public UserAccount(string username, int age)

        // TODO: Implement behaviors
        // public void LockAccount()
        // public void UnlockAccount()
        // public void ChangeUsername(string newUsername)
        // public void ChangeAge(int newAge)
    }
}
```

---

## Step 2 – Write Unit Tests

To practice unit testing, complete the UserAccountTests.cs file using  **xUnit**.

### Test Requirements
- Tests that verify state changes using assertions such as `Assert.True` or `Assert.False`
- Tests that verify invalid input results in exceptions using `Assert.Throws`
- At least one test that verifies expected values using `Assert.Equal`
- Use both `[Fact]` and `[Theory]` test attributes

---

## Step 3 – Run and Verify

1. Ensure all tests pass

---

