using HorseManager2022;
using HorseManager2022.UI;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Create Screens
Topbar topbar = new Topbar();
ScreenMenu initialScreen = new ScreenMenu("Welcome to Horse Manager 2022");
ScreenMenu loadGameScreen = new ScreenMenu("Load game", initialScreen);
ScreenCity cityScreen = new ScreenCity("City", topbar, loadGameScreen);
ScreenHouse vetScreen = new ScreenHouse("Vet", topbar, cityScreen);
ScreenHouse shopScreen = new ScreenHouse("Shop", topbar, cityScreen);
ScreenHouse stableScreen = new ScreenHouse("Stable", topbar, cityScreen);
ScreenHouse raceTrackScreen = new ScreenHouse("RaceTrack", topbar, cityScreen);


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
            cityScreen.title = "In Game Menu - " + save;
            cityScreen.Show();


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
        cityScreen.title = "In Game Menu - " + savename;
        cityScreen.Show();

    });
    

}));


/*
    Initial [Screen] --> Credits [Option]
*/
initialScreen.AddOption(new Option("Credits", (lastScreen) => { UI.ShowCreditScreen(lastScreen); }));


/*
    City [Screen] --> Vet [Option]
*/
cityScreen.AddOption(new Option("Vet", (lastScreen) => {

    vetScreen.Show();

}));

/*
    Vet [Screen] --> Details [Option]
*/

vetScreen.AddOption(new Option("Details", (lastScreen) => { 
    
    Console.WriteLine("Details");
    Console.ReadKey();
    lastScreen.Show();
    
}));

/*
    Vet [Screen] --> Upgrade [Option]
*/

vetScreen.AddOption(new Option("Upgrade", (lastScreen) => { 
    
    Console.WriteLine("Upgrade");
    Console.ReadKey();

    lastScreen.Show();
}));

/*
    City [Screen] --> Shop [Option]
*/
cityScreen.AddOption(new Option("Shop", (lastScreen) => {

    shopScreen.Show();

}));

/*
    Shop [Screen] --> Buy [Option]
*/

shopScreen.AddOption(new Option("Buy", (lastScreen) => {

    Console.WriteLine("Buy");

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    Shop [Screen] --> Sell [Option]
*/

shopScreen.AddOption(new Option("Sell", (lastScreen) => {

    Console.WriteLine("Sell");

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    City [Screen] --> Stable [Option]
*/
cityScreen.AddOption(new Option("Stable", (lastScreen) => {

    stableScreen.Show();

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    Stable [Screen] --> Horses [Option]
*/

stableScreen.AddOption(new Option("Horses", (lastScreen) => {

    Console.WriteLine("Horses");

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    Stable [Screen] --> Jockeys [Option]
*/

stableScreen.AddOption(new Option("Jockeys", (lastScreen) => {

    Console.WriteLine("Jockeys");

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    City [Screen] --> Racetrack [Option]
*/
cityScreen.AddOption(new Option("Racetrack", (lastScreen) => {


    raceTrackScreen.Show();

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    Racetrack [Screen] --> Train [Option]
*/

raceTrackScreen.AddOption(new Option("Train", (lastScreen) => {

    Console.WriteLine("Train");

    Console.ReadKey();

    lastScreen.Show();

}));

/*
    Racetrack [Screen] --> Race [Option]
*/

raceTrackScreen.AddOption(new Option("Race", (lastScreen) => {

    Console.WriteLine("Race");

    Console.ReadKey();

    lastScreen.Show();

}));


/*
    [Topbar] --> Calendar [Option]
*/
topbar.AddOption(new Option("Calendar", (lastScreen) => {

    Console.WriteLine("Calendar");

    Console.ReadKey(); // Esperar tecla

    lastScreen.Show(); // No final chamar o Show() do último Screen para voltar para o anterior e ficar no ciclo

}));


/*
    [Topbar] --> Sleep [Option]
*/
topbar.AddOption(new Option("Sleep", (lastScreen) => {

    Console.WriteLine("Sleep");

    Console.ReadKey();

    lastScreen.Show();

}));

// ---------------- Game Start ---------------- \\
Canvas.ShowInitialScreen();




