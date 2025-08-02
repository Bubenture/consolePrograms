## Console Programs in C#

</br>
<div>
    <a href="README.md">
        <img src="https://img.shields.io/badge/README-RU-blue?color=006400&labelColor=006400&style=for-the-badge">
    </a>
    <a href="README.en.md">
        <img src="https://img.shields.io/badge/README-ENG-blue?color=44944a&labelColor=1C2325&style=for-the-badge">
    </a>
</div>

### Array of Pointers.cs
The program implements a user menu for working with an array of pointers to double-type elements.

#### Initialization:
The program creates an array of 8 elements of type **double** and an array of pointers to these elements.

#### Menu:
The user can choose from several menu options:
- **Fill the array**: The user inputs values for each element of the array.
- **Display element address**: The user inputs an index, and the program displays the address of the element whose index is 2 less than the entered index.
- **Display element value**: The user inputs an index, and the program displays the value of the element whose index is 5 more than the entered index.

#### Loop:
The program runs in a loop, allowing the user to perform actions until they decide to exit by selecting the corresponding menu option.

#### Safety:
Unsafe code is used, allowing pointer manipulation, but it requires caution in memory management.

---

### Stepwise Multidimensional Arrays.cs
The program implements a user menu for working with three one-dimensional arrays.

#### Array Initialization:
The program creates three arrays:
- The first array contains 8 floating-point numbers.
- The second array contains 6 floating-point numbers.
- The third array will be used to store computation results.

#### Menu:
The user can choose from the following menu options:
- **Fill the 1st array**: The user inputs values for the first array.
- **Fill the 2nd array**: The user inputs values for the second array.
- **Display the 3rd array**: The program computes and displays:
  - The arithmetic mean of the elements in the first array.
  - The arithmetic mean of the elements in the second array.
  - The difference between the maximum and minimum elements of the first array.
  - The difference between the maximum and minimum elements of the second array.

#### Loop:
The program runs in a loop, allowing the user to perform actions until they decide to exit by selecting the corresponding menu option.

#### Result Output:
When displaying results, the program formats numbers to two decimal places and allows the user to see all arrays and computation results.

---

### Strings and Byte Files.cs
The program provides a user menu for working with text files.

#### Initialization:
The program creates a user menu with several options for working with text and files.

#### Menu:
The user can choose from the following options:
- **Convert text to an array of strings and write to a byte file**: The user inputs text, which is written to the file `c#.txt`. Input ends when the user enters the character `!`.
- **Read text from the byte file**: The program reads text from `c#.txt`, replaces spaces with underscores, determines the lengths of the strings, and writes the results to the file `c#1.txt`. It also outputs the number of space replacements.
- **Read data from the resulting text file**: The program reads and displays the contents of the file `c#.txt` on the screen.

#### Error Handling:
The program uses `try-finally` blocks to safely close file streams, preventing resource leaks.

#### Result Output:
The program displays string lengths and the number of space replacements, as well as allowing the user to see the contents of the files.

---

### Strings.cs
The program provides a user menu for working with strings, allowing the replacement of characters with odd ASCII codes.

#### Initialization:
The program creates an infinite loop in which the user can interact with the menu.

#### Menu:
The user can choose from the following options:
- **Display string**: The user inputs a string, which is saved for further processing.
- **Replace characters**: The program replaces all characters in the string with odd ASCII codes with a character specified by the user. The program also outputs the number of replacements made.
- **Exit**: The user can exit the program.

#### String Processing:
- When option 1 is selected, the program prompts for a string input and saves it.
- When option 2 is selected, the program displays the ASCII codes of each character in the string, then replaces characters with odd codes with the specified character and counts the number of replacements.

#### Result Output:
The program displays the modified string and the number of replacements made during the process.

#### Error Handling:
The program handles user input and displays a message if an invalid menu option is selected.
