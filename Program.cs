using System.Diagnostics;

Random number = new Random();

int firstNumber = number.Next(0, 101);
int secondNumber = number.Next(0, 101);
int correctAnswer = 0;

int total = 0;
int result = 0;

int correctAnswerForSum = 0;
int correctAnswerForSubtraction = 0;
int correctAnswerForMultiplication = 0;
int correctAnswerForDivision = 0;
int correctAnswerForSquare = 0;

bool validEntry = false;

string? readInputResult;
string? readResult;
string menuSelection = "";
string mathGame = "";
string lapTime = "";

int[,] scores = new int[,] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };
int[] score = new int[] { 0, 0, 0, 0, 0 };
string[] mathOperations = new string[] { "Addition", "Subtraction", "Multiplication", "Division", "Square2d" };
string[] mathGames = new string[33];
string[] lapTimes = new string[33];

int counter = 0;
int rounds = 0;
int counterLap = 0;
int questionsToPlay = 0;

Console.WriteLine();
Console.WriteLine("Pick the number of operations you want to calculate:");
readInputResult = Console.ReadLine();
validEntry = int.TryParse(readInputResult, out questionsToPlay);
Console.WriteLine($"Rounds to play: {questionsToPlay}");

do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Math Game app. Your main menu options are:");
    Console.WriteLine(" 0. To change the number of math Games you want to play");
    Console.WriteLine(" 1. To calculate the Sum of two integers");
    Console.WriteLine(" 2. To calculate the Subtraction of two integers");
    Console.WriteLine(" 3. To calculate the Multiplication of two integers");
    Console.WriteLine(" 4. To calculate the Division of two decimals (2 digits Rounded)");
    Console.WriteLine(" 5. To calculate the Division of two integers");
    Console.WriteLine(" 6. To calculate the Square of one integer");
    Console.WriteLine(" 7. To display the scores");
    Console.WriteLine(" 8. To display the previous math Games");
    Console.WriteLine(" 9. To play the Random Math Game");
    Console.WriteLine(" 10. To display the previous time lapses for RandomGames");

    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (questionsToPlay > 0)
    {
        if (readResult != null)
        {
            menuSelection = readResult.ToLower();
        }

        Console.WriteLine($"You have {questionsToPlay} Rounds to play");
    }
    else
    {
        Console.WriteLine("You don't have more Rounds to play");
        return;
    }

    switch (menuSelection)
    {
        case "0":
            Console.WriteLine("Pick the new number of questions:");
            readInputResult = Console.ReadLine();
            validEntry = int.TryParse(readInputResult, out questionsToPlay);
            Console.WriteLine($"You have now {questionsToPlay} Rounds to play:");

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "1":
            questionsToPlay--;
            GenerateRandomNumbers();
            MakeSum();

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            questionsToPlay--;
            GenerateRandomNumbers();
            MakeSubtraction();

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            questionsToPlay--;
            GenerateRandomNumbers();
            MakeMultiplication();

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            questionsToPlay--;
            MakeDivisionForDecimals();

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            questionsToPlay--;
            MakeDivisionForIntegers();

            // try catch 
            // What is the recommended approach for catching exceptions in C#?
            //   Catch only the exceptions that your code knows how to recover from.

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


        case "6":
            questionsToPlay--;
            GenerateRandomNumbers();
            MakeSquare();

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine($"Total Correct answers:\t{correctAnswer}");
            Console.WriteLine($"\tTotal Correct answers for Sum:\t\t\t{correctAnswerForSum}");
            Console.WriteLine($"\tTotal Correct answers for Subtraction:\t\t{correctAnswerForSubtraction}");
            Console.WriteLine($"\tTotal Correct answers for Multiplication:\t{correctAnswerForMultiplication}");
            Console.WriteLine($"\tTotal Correct answers for Division:\t\t{correctAnswerForDivision}");
            Console.WriteLine($"\tTotal Correct answers for Square:\t\t{correctAnswerForSquare}");

            for (int i = 0; i < scores.Length / 2; i++)
            {
                Console.WriteLine();
                Console.Write($"\t{mathOperations[i]}");
                Console.Write($"\t{scores[i, 1]}\n");

            }
            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("Previus games:");
            for (int i = 0; i < mathGames.Length; i++)
            {
                if (mathGames[i] != null)
                {
                    Console.WriteLine(mathGames[i]);
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "9":
            questionsToPlay--;

            Console.WriteLine("Random Math Game:");
            Console.WriteLine("Pick the number of questions:");
            readInputResult = Console.ReadLine();
            validEntry = int.TryParse(readInputResult, out rounds);

            var stopWatch = Stopwatch.StartNew();

            while (rounds > 0)
            {
                Console.WriteLine($"Rounds to play: {rounds}");
                GenerateRandomGame();
            }
            Console.WriteLine("End of Random Math Game");

            stopWatch.Stop();
            // Console.WriteLine(stopWatch.Elapsed.Seconds);
            Console.WriteLine($"You took: {stopWatch.Elapsed.Seconds} seconds to complete the game.");

            counterLap++;
            lapTime = String.Format($"{stopWatch.Elapsed.Seconds}");
            lapTimes[counterLap] = lapTime;

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "10":
            Console.WriteLine("Previus Lap times for random games:");
            for (int i = 0; i < lapTimes.Length; i++)
            {
                if (lapTimes[i] != null)
                {
                    Console.WriteLine();
                    Console.Write($"\tRandomGame {i}");
                    Console.Write($"\t{lapTimes[i]} seconds\n");
                }
            }
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
    }

} while (menuSelection != "exit");


void GenerateRandomNumbers()
{
    firstNumber = number.Next(0, 101);
    secondNumber = number.Next(0, 101);

    if ((firstNumber == 0) && (secondNumber == 0))
    {
        firstNumber = number.Next(0, 101);
        secondNumber = number.Next(0, 101);
    }

}

void MakeSum()
{
    rounds--;
    counter++;

    total = firstNumber + secondNumber;

    mathGame = String.Format($"{firstNumber} + {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"Calculate the Sum: {firstNumber} + {secondNumber}");
    readInputResult = Console.ReadLine();
    validEntry = int.TryParse(readInputResult, out result);

    while (validEntry == false)
    {
        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
        readInputResult = Console.ReadLine();
        validEntry = int.TryParse(readInputResult, out result);
    }

    if (result == total)
    {
        Console.WriteLine("Correct answer for Addition ");
        correctAnswer++;
        correctAnswerForSum++;
    }
    else
    {
        Console.WriteLine("Wrong answer for Addition ");
        Console.WriteLine($"Correct: {total}");
    }

    evenOrOdd();

    scores[0, 1] = correctAnswerForSum;
    Console.WriteLine();

}

void MakeSubtraction()
{
    rounds--;
    counter++;

    total = firstNumber - secondNumber;

    mathGame = String.Format($"{firstNumber} - {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"Calculate the Subtraction: {firstNumber} - {secondNumber}");
    readInputResult = Console.ReadLine();
    validEntry = int.TryParse(readInputResult, out result);

    while (validEntry == false)
    {
        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
        readInputResult = Console.ReadLine();
        validEntry = int.TryParse(readInputResult, out result);
    }

    if (result == total)
    {
        Console.WriteLine("Correct answer for Subtraction ");
        correctAnswer++;
        correctAnswerForSubtraction++;
    }
    else
    {
        Console.WriteLine("Wrong answer for Subtraction ");
        Console.WriteLine($"Correct: {total}");
    }

    evenOrOdd();

    scores[1, 1] = correctAnswerForSubtraction;
    // Console.WriteLine($"Total Correct answers for subtraction: {scores[1, 1]}");
    Console.WriteLine();
}

void MakeMultiplication()
{
    rounds--;
    counter++;

    total = firstNumber * secondNumber;
    mathGame = String.Format($"{firstNumber} * {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"Calculate the Multiplication: {firstNumber} * {secondNumber}");
    readInputResult = Console.ReadLine();
    validEntry = int.TryParse(readInputResult, out result);

    while (validEntry == false)
    {
        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
        readInputResult = Console.ReadLine();
        validEntry = int.TryParse(readInputResult, out result);

    }

    if (result == total)
    {
        Console.WriteLine("Correct answer for Multiplication ");
        correctAnswer++;
        correctAnswerForMultiplication++;
    }
    else
    {
        Console.WriteLine("Wrong answer for Multiplication ");
        Console.WriteLine($"Correct: {total}");
    }

    evenOrOdd();

    scores[2, 1] = correctAnswerForMultiplication;
    Console.WriteLine();
}

void MakeDivisionForDecimals()
{
    GenerateRandomNumbers();

    while (secondNumber == 0)
    {
        GenerateRandomNumbers();
    }

    rounds--;
    counter++;

    decimal firstNum = (decimal)firstNumber;
    decimal totalForDivision = firstNum / secondNumber;
    decimal totalRounded = Math.Round(totalForDivision, 2);

    mathGame = String.Format($"{firstNumber} / {secondNumber} = {totalRounded}");
    mathGames[counter] = mathGame;

    decimal resultDecimal = 0;
    Console.WriteLine($"Calculate the Division: {firstNumber} / {secondNumber}");
    readInputResult = Console.ReadLine();
    validEntry = decimal.TryParse(readInputResult, out resultDecimal);

    while (validEntry == false)
    {
        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
        readInputResult = Console.ReadLine();
        validEntry = decimal.TryParse(readInputResult, out resultDecimal);
    }

    if (resultDecimal == totalRounded)
    {
        Console.WriteLine("Correct answer for Division ");
        correctAnswer++;
        correctAnswerForDivision++;
    }
    else
    {
        Console.WriteLine("Wrong answer for Division ");
        Console.WriteLine($"Correct: {totalRounded}");
    }

    scores[3, 1] = correctAnswerForDivision;
    Console.WriteLine();
}

void MakeDivisionForIntegers()
{
    GenerateRandomNumbers();

    while (secondNumber == 0)
    {
        GenerateRandomNumbers();
    }

    rounds--;
    counter++;

    total = firstNumber / secondNumber;
    mathGame = String.Format($"{firstNumber} / {secondNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"Calculate the Division: {firstNumber} / {secondNumber}");
    readInputResult = Console.ReadLine();
    validEntry = int.TryParse(readInputResult, out result);

    while (validEntry == false)
    {
        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
        readInputResult = Console.ReadLine();
        validEntry = int.TryParse(readInputResult, out result);
    }

    if (result == total)
    {
        Console.WriteLine("Correct answer for Division ");
        correctAnswer++;
        correctAnswerForDivision++;
    }
    else
    {
        Console.WriteLine("Wrong answer for Division ");
        Console.WriteLine($"Correct: {total}");
    }

    evenOrOdd();
    scores[3, 1] = correctAnswerForDivision;
    Console.WriteLine();

}

void MakeSquare()
{
    rounds--;
    counter++;

    total = firstNumber * firstNumber;

    mathGame = String.Format($"{firstNumber} * {firstNumber} = {total}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"Calculate the Square: {firstNumber} x {firstNumber}");
    readInputResult = Console.ReadLine();
    validEntry = int.TryParse(readInputResult, out result);

    while (validEntry == false)
    {
        Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
        readInputResult = Console.ReadLine();
        validEntry = int.TryParse(readInputResult, out result);
    }

    if (result == total)
    {
        Console.WriteLine("Correct answer for Square ");
        correctAnswer++;
        correctAnswerForSquare++;
    }
    else
    {
        Console.WriteLine("Wrong answer for Square ");
        Console.WriteLine($"Correct: {total}");
    }

    evenOrOdd();

    scores[4, 1] = correctAnswerForSquare;
    Console.WriteLine();
}

void GenerateRandomGame()
{
    // create some logic to random operations
    int randomMathGame = number.Next(mathOperations.Length);

    if (randomMathGame == 1)
    {
        GenerateRandomNumbers();
        MakeSum();
    }
    else if (randomMathGame == 2)
    {
        GenerateRandomNumbers();
        MakeSubtraction();
    }
    else if (randomMathGame == 3)
    {
        GenerateRandomNumbers();
        MakeMultiplication();
    }
    else if (randomMathGame == 4)
    {
        GenerateRandomNumbers();
        MakeDivisionForIntegers();
    }
    else
    {
        GenerateRandomNumbers();
        MakeSquare();
    }

}

void evenOrOdd()
{
    if (total % 2 == 0)
    {
        Console.WriteLine($"{total} is an even number");
    }
    else
    {
        Console.WriteLine($"{total} is an odd number");
    }
}






