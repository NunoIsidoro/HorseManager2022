using HorseManager2022;
using HorseManager2022.UI;


// Create Screens
ScreenMenu initialScreen = new ScreenMenu("Welcome to Horse Manager 2022");
ScreenMenu loadGameScreen = new ScreenMenu("Load game", initialScreen);
ScreenCity mainGameScreen = new ScreenCity("In Game Menu", initialScreen);


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
            mainGameScreen.title = "In Game Menu - " + save;
            mainGameScreen.Show();


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
        mainGameScreen.title = "In Game Menu - " + savename;
        mainGameScreen.Show();

    });
    

}));


/*
    Initial [Screen] --> Credits [Option]
*/
initialScreen.AddOption(new Option("Credits", (screen) => { UI.ShowCreditScreen(screen); }));





// ---------------- Game Start ---------------- \\
Canvas.ShowInitialScreen();




