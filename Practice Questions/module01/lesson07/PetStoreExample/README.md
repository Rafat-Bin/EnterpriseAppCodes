# Exercise Clases and Objects
# Pet Store

Create a console application that simulates adding animals to a pet store.

Implement object oriented programming and encapsulation where required.

## Requirements

1. The user must be presented with a menu listing the options to to add an animal to the pet store or quit the program. If the user enters an invalid value, they muse be reprompted with the options.
2. If the user chooses to add an animal, they must be provided with the option to add either a Dog, Cat, or a Bird. If they enter in invalid option, the program returns to the main menu.
3. Three classes should be implemented in a new subfolder called `Animals`. Create this folder first.
4. There are three classes to implement
    - Dog
        - Properties
            - Name: String
            - Age: Int
                - Must be from 1-20
            - Breed: String (private setter)
        - Methods
            - override ToString to print the Name, Age, and Breed.
            - MakeNoise(): Prints "{name} barks loudly"
    - Cat
        - Properties
            - Name: String
            - Age: Int
                - Must be from 1-30
            - Breed: String (private setter)
            - AngerLevel: Int (private setter)
        - Methods
            - Constructor initializes AngerLevel to be a random integer from 1-100 inclusive.
            - override ToString to print the Name, Age, and Breed.
            - MakeNoise(): Prints "{name} purrs quietly."
    - Bird
        - Properties
            - Name: String
            - Age: Int
                - Must be from 1-80
            - Species: String
        - Methods
            - override ToString to print the Name, Age, and Breed.
            - MakeNoise(): Prints "{name} chirps excitedly."
5. Create the following methods in the Program.cs file:
    - `PrintMainMenu()`: void method that prints the opening menu
    - `PrintSelectMenu()`: void method that prints the sub menu to add a new animal
    - `AddDog()`: void method that adds a new dog
    - `AddCat()`: void method that adds a new cat
    - `AddBird()`: void method that adds a new bird
    - `GetString(string prompt)`: method that prompts the user for a string using the `prompt` parameter. It returns the string the user entered.
    - `GetInt(string prompt)`: prompts the user for an integer using the `prompt` parameter. _Safely_ gets an input from the user implemented proper error handling. Returns the integer the user entered.
6. When adding a dog or a cat, The user should be prompted to add the name, age, and breed properties. Included validation for numeric values.
7. When adding a bird, the user should be prompted to add the name, age, and species properties. Include validation for numeric values.
8. Use these values to create a new object of the specified type. 
9. After creation, print the details of the animal, making use of the ToString() override. Call the MakeNoise() method for each animal.

Sample Output:
```
Pet Store.
1. Add Animal
2. Quit
Enter choice: 1
Select Animal
1. Add dog.
2. Add cat.
3. Add bird.
Enter choice: 1
Enter the name: Ranger
Enter the age: 18
Enter the breed: Border Collie
Added Name: Ranger, Age: 18, Breed: Border Collie
Ranger barks loudly.
```

Feel free to expand on this by adding extra options in the menu or animals with different properties or methods. Be creative!