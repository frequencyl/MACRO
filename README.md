# Macro_Minstrel

https://github.com/frequencyl/Macro/assets/118335871/f9dcb2f8-fb14-4bd6-b072-ad8b66e935de
# Macro Minstrel

**Macro Minstrel** is a simple Windows application that allows users to create and use keyboard macros.

## Features

- Define up to four different macros.
- Assign macros to specific keys on the keyboard.
- Start and stop the macro execution.

## Prerequisites

- Windows operating system.
- Microsoft .NET Framework.

## Installation

1. Clone or download the repository to your local machine.
2. Open the solution file (`Macro_Minstrel.sln`) in Visual Studio.
3. Build the solution to generate the executable.

## Usage

1. Launch the application (`Macro_Minstrel.exe`).
2. Enter the desired macros in the text boxes provided.
3. Press the Start button to activate the macro functionality.
4. Press the specified keys on the keyboard to trigger the corresponding macros.
5. Press the Stop button to deactivate the macro functionality.

## How It Works

- The application listens for specific key presses using the `GetAsyncKeyState` function from the `User32.dll`.
- When a designated key is pressed, the corresponding macro is executed by sending keystrokes using `SendKeys.Send`.
- Macros are user-defined strings entered into text boxes within the application.


## Acknowledgments

- This application was created as a simple demonstration of keyboard macro functionality in C#.


