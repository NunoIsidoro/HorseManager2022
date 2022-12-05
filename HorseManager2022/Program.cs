using HorseManager2022;
using HorseManager2022.UI;

// Create UI
ScreenMenu initialScreen = new ScreenMenu("Welcome to Horse Manager 2022");
initialScreen.AddOption(new Option("Load game", (screen) => { UI.ShowLoadGameScreen(screen); }));
initialScreen.AddOption(new Option("New game", (screen) => { UI.ShowLoadGameScreen(screen); }));
initialScreen.AddOption(new Option("Credits", (screen) => { UI.ShowCreditScreen(screen); }));

Canvas canvas = new Canvas();
canvas.AddScreen(initialScreen);


// Show UI
canvas.ShowInitialScreen();




