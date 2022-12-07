using HorseManager2022;
using HorseManager2022.UI;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Create Screens
ScreenMenu initialScreen = new ScreenMenu("Welcome to Horse Manager 2022");
ScreenMenu loadGameScreen = new ScreenMenu("Load game", initialScreen);
ScreenCity cityGameScreen = new ScreenCity("City", initialScreen);


// ---------------- Initial Screen Options ---------------- \\

/*
    Initial [Screen] --> Load game [Option]
*/
initialScreen.AddOption(new Option("Load game", (screen) => {


    loadGameScreen.ClearOptions();
    foreach (string save in Game.saves)
    {
        loadGameScreen.AddOption(new Option(save, (screen) =>
        {

            // Start game
            cityGameScreen.title = "In Game Menu - " + save;
            cityGameScreen.Show();


        }));
    }

    loadGameScreen.Show();

}));


/*
    Initial [Screen] --> New game [Option]
*/
initialScreen.AddOption(new Option("New game", (screen) => { 

    
    UI.ShowCreateNewSaveScreen((savename) => {

        Game game = new Game(savename);
        game.CreateSave();

        // Start game
        cityGameScreen.title = "In Game Menu - " + savename;
        cityGameScreen.Show();

    });
    

}));


/*
    Initial [Screen] --> Credits [Option]
*/
initialScreen.AddOption(new Option("Credits", (screen) => { UI.ShowCreditScreen(screen); }));


/*
    City [Topbar] --> Calendar [Option]
*/
cityGameScreen.topbar.AddOption(new Option("Calendar", (screen) => { Console.WriteLine("Calendar"); }));


/*
    City [Topbar] --> Sleep [Option]
*/
cityGameScreen.topbar.AddOption(new Option("Sleep", (screen) => { Console.WriteLine("Sleep"); }));


/*
    City [Screen] --> Vet [Option]
*/
cityGameScreen.AddOption(new Option("Vet", (screen) => { Console.WriteLine("Vet"); }));

/*
    City [Screen] --> Shop [Option]
*/
cityGameScreen.AddOption(new Option("Shop", (screen) => { Console.WriteLine("Shop"); }));

/*
    City [Screen] --> Stable [Option]
*/
cityGameScreen.AddOption(new Option("Stable", (screen) => { Console.WriteLine("Stable"); }));

/*
    City [Screen] --> Racetrack [Option]
*/
cityGameScreen.AddOption(new Option("Racetrack", (screen) => { Console.WriteLine("Racetrack"); }));


// ---------------- Game Start ---------------- \\
Canvas.ShowInitialScreen();




