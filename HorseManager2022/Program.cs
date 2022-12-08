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
initialScreen.AddOption(new Option("Load game", (lastScreen) => {


    loadGameScreen.ClearOptions();
    foreach (string save in Game.saves)
    {
        loadGameScreen.AddOption(new Option(save, (lastScreen) =>
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
initialScreen.AddOption(new Option("New game", (lastScreen) => { 

    
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
initialScreen.AddOption(new Option("Credits", (lastScreen) => { UI.ShowCreditScreen(lastScreen); }));


/*
    City [Topbar] --> Calendar [Option]
*/
cityGameScreen.topbar.AddOption(new Option("Calendar", (lastScreen) => { 

    
    Console.WriteLine("Calendar");

    Console.ReadKey(); // Esperar tecla

    lastScreen.Show(); // No final chamar o Show() do último Screen para voltar para o anterior e ficar no ciclo

}));


/*
    City [Topbar] --> Sleep [Option]
*/
cityGameScreen.topbar.AddOption(new Option("Sleep", (lastScreen) => { 
    
    Console.WriteLine("Sleep");

    Console.ReadKey();

}));


/*
    City [Screen] --> Vet [Option]
*/
cityGameScreen.AddOption(new Option("Vet", (lastScreen) => { 
    
    Console.WriteLine("Vet");

    Console.ReadKey();

}));

/*
    City [Screen] --> Shop [Option]
*/
cityGameScreen.AddOption(new Option("Shop", (lastScreen) => { 
    
    Console.WriteLine("Shop");

    Console.ReadKey();

}));

/*
    City [Screen] --> Stable [Option]
*/
cityGameScreen.AddOption(new Option("Stable", (lastScreen) => { 
    
    Console.WriteLine("Stable");

    Console.ReadKey();

}));

/*
    City [Screen] --> Racetrack [Option]
*/
cityGameScreen.AddOption(new Option("Racetrack", (lastScreen) => { 
    
    
    Console.WriteLine("Racetrack");

    Console.ReadKey();

}));


// ---------------- Game Start ---------------- \\
Canvas.ShowInitialScreen();




