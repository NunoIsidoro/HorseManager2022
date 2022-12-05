using HorseManager2022;
using HorseManager2022.UI;

// Create UI
ScreenMenu initialScreen = new ScreenMenu("Welcome to Horse Manager 2022", true);
initialScreen.AddOption(new Option("Login", (screen) => { UI.ShowLoginScreen(screen); }));
initialScreen.AddOption(new Option("Register", (screen) => { UI.ShowRegisterScreen(screen); }));
initialScreen.AddOption(new Option("Credits", (screen) => { UI.ShowCreditScreen(screen); }));

Canvas canvas = new Canvas();
canvas.AddScreen(initialScreen);


// Show UI
canvas.ShowInitialScreen();




