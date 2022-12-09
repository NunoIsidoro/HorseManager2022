using HorseManager2022;
using HorseManager2022.UI;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Create UI
Canvas canvas = new Canvas();
Topbar topbar = new Topbar();
ScreenMenu initialScreen = new ScreenMenu("Welcome to Horse Manager 2022");
ScreenMenu loadGameScreen = new ScreenMenu("Load game", initialScreen);
ScreenCity cityScreen = new ScreenCity("City", topbar, loadGameScreen);
ScreenHouse vetScreen = new ScreenHouse("Vet", topbar, cityScreen);
ScreenHouse shopScreen = new ScreenHouse("Shop", topbar, cityScreen);
ScreenHouse stableScreen = new ScreenHouse("Stable", topbar, cityScreen);
ScreenHouse raceTrackScreen = new ScreenHouse("RaceTrack", topbar, cityScreen);
canvas.screens.AddRange(new Screen[] { initialScreen, loadGameScreen, cityScreen, vetScreen, shopScreen, stableScreen, raceTrackScreen });

// ---------------- Initial Screen Options ---------------- \\

/*
    Initial [Screen] --> Load game [Option]
*/
initialScreen.AddOption("Load game", loadGameScreen, () => {

    loadGameScreen.ClearOptions();
    foreach (string save in Game.saves)
    {
        loadGameScreen.AddOption(save, cityScreen, () =>
        {

            // Start game
            Game game = new Game(canvas, save);
            cityScreen.title = "City";

        });
    }

});


/*
    Initial [Screen] --> New game [Option]
*/
initialScreen.AddOption("New game", loadGameScreen, () => { 

    
    UI.ShowCreateNewSaveScreen((savename) => {

        Game game = new Game(canvas, savename, true);
        cityScreen.title = "In Game Menu - " + savename;

    });
    

});


/*
    Initial [Screen] --> Credits [Option]
*/
initialScreen.AddOption("Credits", initialScreen, () => { UI.ShowCreditScreen(); });


/*
    City [Screen] --> Vet [Option]
*/
cityScreen.AddOption("Vet", vetScreen, () => {

    // vetScreen.Show();
    Console.WriteLine("Vet");
    Console.ReadKey();

});

/*
    Vet [Screen] --> Details [Option]
*/

vetScreen.AddOption("Details", vetScreen, () => { 
    
    Console.WriteLine("Details");
    Console.ReadKey();

});

/*
    Vet [Screen] --> Upgrade [Option]
*/

vetScreen.AddOption("Upgrade", vetScreen, () => { 
    
    Console.WriteLine("Upgrade");
    Console.ReadKey();
    
});

/*
    City [Screen] --> Shop [Option]
*/
cityScreen.AddOption("Shop", shopScreen, () => {

    // shopScreen.Show();

});

/*
    Shop [Screen] --> Buy [Option]
*/

shopScreen.AddOption("Buy", shopScreen, () => {

    Console.WriteLine("Buy");

    Console.ReadKey();
    

});

/*
    Shop [Screen] --> Sell [Option]
*/

shopScreen.AddOption("Sell", shopScreen, () => {

    Console.WriteLine("Sell");

    Console.ReadKey();
    

});

/*
    City [Screen] --> Stable [Option]
*/
cityScreen.AddOption("Stable", stableScreen, () => {

    // stableScreen.Show();

    Console.ReadKey();
    

});

/*
    Stable [Screen] --> Horses [Option]
*/

stableScreen.AddOption("Horses", stableScreen, () => {

    Console.WriteLine("Horses");

    Console.ReadKey();
    

});

/*
    Stable [Screen] --> Jockeys [Option]
*/

stableScreen.AddOption("Jockeys", stableScreen, () => {

    Console.WriteLine("Jockeys");

    Console.ReadKey();

});

/*
    City [Screen] --> Racetrack [Option]
*/
cityScreen.AddOption("Racetrack", raceTrackScreen, () => {


    Console.WriteLine("Racetrack");
    Console.ReadKey();
    

});

/*
    Racetrack [Screen] --> Train [Option]
*/

raceTrackScreen.AddOption("Train", raceTrackScreen, () => {

    Console.WriteLine("Train");

    Console.ReadKey();

});

/*
    Racetrack [Screen] --> Race [Option]
*/

raceTrackScreen.AddOption("Race", raceTrackScreen, () => {

    Console.WriteLine("Race");

    Console.ReadKey();

});


/*
    [Topbar] --> Calendar [Option]
*/
topbar.AddOption("Calendar", cityScreen, () => {

    Console.WriteLine("Calendar");

    Console.ReadKey(); // Esperar tecla

});


/*
    [Topbar] --> Sleep [Option]
*/
topbar.AddOption("Sleep", cityScreen, () => {

    Console.WriteLine("Sleep");

    Console.ReadKey();

});


// ---------------- Game Loop ---------------- \\
Screen? activeScreen, nextScreen;
activeScreen = canvas.ShowInitialScreen();


while (activeScreen != null)
{
    nextScreen = activeScreen.Show();
    activeScreen = nextScreen;
}


Console.Clear();
Console.WriteLine("Thanks for playing!");
