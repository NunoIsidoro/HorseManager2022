using HorseManager2022;
using HorseManager2022.Models;
using HorseManager2022.UI;
using HorseManager2022.UI.Dialogs;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Create UI
Topbar topbar = new();
ScreenMenu initialScreen = new("Welcome to Horse Manager 2022");
ScreenMenu loadGameScreen = new("Load game", initialScreen);
ScreenCity cityScreen = new("City", topbar, loadGameScreen);
ScreenHouse vetScreen = new("Vet", topbar, cityScreen);
ScreenHouse shopScreen = new("Shop", topbar, cityScreen);
ScreenHouse stableScreen = new("Stable", topbar, cityScreen);
ScreenHouse raceTrackScreen = new("RaceTrack", topbar, cityScreen);
CalendarScreen calendarScreen = new("Calendar", topbar, cityScreen);
Player? player = null;

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
            Game.saveName = save;
            player = Player.GetSave();
            cityScreen.title = "City";

        });
    }

});


/*
    Initial [Screen] --> New game [Option]
*/
initialScreen.AddOption("New game", initialScreen, () => { 

    
    UI.ShowCreateNewSaveScreen((savename) => {

        Game.saveName = savename;
        Game.CreateNewSave();
        player = Player.GetSave();
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
cityScreen.AddOption("Vet", vetScreen, () => {});

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
cityScreen.AddOption("Shop", shopScreen, () => {});

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
cityScreen.AddOption("Stable", stableScreen, () => {});

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
cityScreen.AddOption("Racetrack", raceTrackScreen, () => {});

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
topbar.AddOption("Calendar", calendarScreen, () => {
    calendarScreen.calendar = new Calendar(player?.date, Event.GetEventsSave());
});


/*
    [Topbar] --> Sleep [Option]
*/
topbar.AddOption("Sleep", cityScreen, () => {

    Console.WriteLine("Sleep");

    Console.ReadKey();

});

/*
DialogConfirmation dialogConfirmation = new DialogConfirmation(0, 0, "Confirmation", "Are you sure you want to exit?", initialScreen, () => { Environment.Exit(0); }, () => { });

dialogConfirmation.Show();
*/

// ---------------- Game Loop ---------------- \\
Screen? activeScreen, nextScreen;
activeScreen = initialScreen.Show(player);


while (activeScreen != null)
{
    nextScreen = activeScreen.Show(player);
    activeScreen = nextScreen;
}


Console.Clear();
Console.WriteLine("Thanks for playing!");
