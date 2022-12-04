using HorseManager2022;
using HorseManager2022.UI;

// Create UI
Screen initialScreen = new Screen();
initialScreen.AddOption(new Option("Login", () => { Canvas.ShowLoginScreen(); }));
initialScreen.AddOption(new Option("Create account", () => { Console.WriteLine("Create account"); }));
initialScreen.AddOption(new Option("Credits", () => { Console.WriteLine("Credits"); }));
initialScreen.AddOption(new Option("Leave", () => { Console.WriteLine("Leave"); }));


// Program loop
/*
while (Game.isRunning)
{
    Canvas.ShowInitialScreen();
    Game.isRunning = false;
}
*/

