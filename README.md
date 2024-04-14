# Console Engine
This is a C# library to make console games.

## Setup
### Visual Studio Code
First create a new folder and open it in VS Code.

Next create a C# console project by typing this in the terminal:
```
dotnet new console
```
Now create a folder named `lib`. This folder is for the custom libraries you will use.
Go to go to the [download list](https://github.com/Saturn7569/Console-Engine/tree/main/download) in this depository and download the latest version of Console Engine.
Extract the `.zip` file and move the folder named `ConsoleEngine` into the `lib` folder.
In the `ConsoleEngine` folder is a file named `ConsoleEngine.cs` so your directory should look something like this:
```
YourVSCodeProject>
  lib>
    ConsoleEngine>
      ConsoleEngine.cs
```
Now open the command palette by pressing `Ctrl + Shift + P` and type `.NET: Generate Assets for Build and Debug`.
Hit enter and wait. It should create a directory named `.vscode`.
Open the `launch.json` file and delete everything.
Now paste this in:
```json
{
    "version": "0.2.0",
    "configurations": [
        {
            // Use IntelliSense to find out which attributes exist for C# debugging
            // Use hover for the description of the existing attributes
            // For further information visit https://github.com/dotnet/vscode-csharp/blob/main/debugger-launchjson.md
            "name": ".NET Core Launch (console)",
            "type": "coreclr",
            "request": "launch",
            "preLaunchTask": "build",
            // If you have changed target frameworks, make sure to update the program path.
            "program": "${workspaceFolder}/bin/Debug/net7.0/c# test.dll",
            "args": [],
            "cwd": "${workspaceFolder}",
            // For more information about the 'console' field, see https://aka.ms/VSCode-CS-LaunchJson-Console
            "console": "externalTerminal",
            "stopAtEntry": false
        },
        {
            "name": ".NET Core Attach",
            "type": "coreclr",
            "request": "attach"
        }
    ]
}
```
Now open the `Program.cs` file and you can start coding. Using the [documentation](https://github.com/Saturn7569/Console-Engine/blob/main/download/documentation.md)
