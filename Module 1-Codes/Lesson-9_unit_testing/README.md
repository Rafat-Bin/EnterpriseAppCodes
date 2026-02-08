# Lesson 09 – Unit Testing with xUnit (C#)

##  Important: How to Run This Code

This repository contains **both**:

1. **Class Library code** (production code)
2. **Unit Tests using xUnit**

 Because of this, the code **cannot be run as a single project**.

---

##  Current State of the Repository

> **Note:**  
> Right now, **all code is placed inside `ClassCode.Core`** for learning and reference purposes.

To properly run and test the code, you must separate it into **two projects**, as explained below.

---

##  Correct Project Setup (Required to Run Tests)

You must create **TWO separate projects** inside the **same solution**.

### 1 Class Library Project

- **Project Type:** Class Library (.NET)
- **Project Name:** `Lesson09.Core`
- **Contains:** All production classes:
  - `Calculator`
  - `Wallet`
  - `ScoreCounter`
  - `ParkingMeter`
  - `Temperature`

This project contains **NO test code**.

---

### 2 xUnit Test Project

- **Project Type:** xUnit Test Project (.NET)
- **Project Name:** `Lesson09.Tests`
- **Must reference:** `Lesson09.Core`
- **Contains:** All unit test classes

 Make sure the test project has a **project reference** to `Lesson09.Core`.

---

##  How to Run the Tests

1. Open the solution in **Visual Studio**
2. Build the solution
3. Open **Test Explorer**
4. Click **Run All Tests**

---

##  If You Don’t Want to Read All This

If you remember how to do this from our lecture:

- Create a **Class Library**
- Create an **xUnit Test Project**
- Add a **project reference**
- Run tests from **Test Explorer**

 It is **exactly the same setup we used in class**.

---

##  Important Notes

-  Do NOT mix test code and class code in the same project
-  `Lesson09.Tests` depends on `Lesson09.Core`
-  Tests will fail if the reference is missing
- Each example demonstrates:
  - Normal behavior testing
  - Exception (throw) testing
  - When to use **[Fact]** vs **[Theory]**

---

##  Why Everything Is in One Place (For Now)

All examples are shown together **only for learning and explanation purposes**.  
In real projects, production code and test code are **always separated**.

---


