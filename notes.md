To create and run the console app:

'''
dotnet new console
dotnet build
dotnet run
''''

To create the VSCode folder with file configurations for Debug:

.net:g
.NET: Generate Assets for Build and Debug

in launch.json file:
"console": "integratedTerminal",

# Work in progress...

[x] Create a Math game containing the 4 basic operations;

[x] The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.
[ ] Check for Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.

[x] Users should be presented with a menu to choose an operation;

[x] You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

[x] You don't need to record results on a database. Once the program is closed the results will be deleted.

[ ] Save C# / .NET code on Github;

- [x] dotnet new gitignore

[ ] Try to implement levels of difficulty;

[x] Add a timer (countdown) to track how long the user takes to finish the game;

- Stopwatch;
- TimeSpan;

[x] Add a function that let's the user pick the number of questions -> only on Randon Game;

[x] Create a 'Random Game' option where the players will be presented with questions from random operations;

[x] Implement function for even / odd;

[x] Implement function for square;

    [x] change functions to static / public?;
    [x] change functions to receive parameters?;
    [x] checked and unchecked statements;

[ ] Implement record results on a database;

[ ] Implement validation for win / lose;

<!--


 -> Obtain a new value for first and second numbers:
                GenerateRandomNumbers();

                -> Call MakeDivisionForIntegers() or  MakeDivisionForDecimals() using the new values:
                MakeDivisionForIntegers();
                MakeDivisionForDecimals();

                -> Still be able to handle exception that are already been catched:
                Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.




-> functions / methods:

<visibility> <return type> <name> (parameters)
{
logic code
} -->

<!--
hint: Using 'master' as the name for the initial branch. This default branch name
hint: is subject to change. To configure the initial branch name to use in all
hint: of your new repositories, which will suppress this warning, call:
hint:
hint:   git config --global init.defaultBranch <name>
hint:
hint: Names commonly chosen instead of 'master' are 'main', 'trunk' and
hint: 'development'. The just-created branch can be renamed via this command:
hint:
hint:   git branch -m <name> -->
<!--

// async void CountDown()
// {
//     // STOPWATCH
//     // var stopWatch = new Stopwatch();
//     // stopWatch.Start();
//     var stopWatch = Stopwatch.StartNew();
//     // var startTime = Stopwatch.GetTimestamp();
//     await Task.Delay(3000);
//     // var endTime = Stopwatch.GetTimestamp();
//     // var interval = Stopwatch.GetElapsedTime(startTime, endTime);
//     // stopWatch.Stop();
//     Console.WriteLine(stopWatch.Elapsed.Seconds);
//     // Console.WriteLine(stopWatch.ElapsedMilliseconds);
//     // Console.WriteLine(stopWatch.ElapsedTicks);
//     // Console.WriteLine(interval);

// }
// // CountDown();
// [ ] Add a timer (countdown) to track how long the user takes to finish the game;
// var stopWatch = Stopwatch.StartNew();
// await Task.Delay(3000);
// stopWatch.Stop();
// Console.WriteLine(stopWatch.Elapsed.Seconds); -->
