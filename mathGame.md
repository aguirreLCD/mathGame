using System.Diagnostics;

Random number = new Random();

string? firstNumberInput = "";
string? secondNumberInput = "";

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
int mathCalculations = 0;

// Console.WriteLine();
// Console.WriteLine("Pick the number of operations if you want to limit the calculations:");
// readInputResult = Console.ReadLine();
// validEntry = int.TryParse(readInputResult, out questionsToPlay);
// Console.WriteLine($"Rounds to play: {questionsToPlay}");

int firstNumber = 0;
int secondNumber = 0;

while (menuSelection != "exit")
{
Console.Clear();

    Console.WriteLine("Welcome to the Calculator app in C#");
    Console.WriteLine("------------------------\n");

    // Ask the user to choose an operation.
    Console.WriteLine("Your main menu options are:");
    Console.WriteLine("------------------------\n");
    // Console.WriteLine(" 0. To change the number of math Games you want to play");
    Console.WriteLine(" 1. To calculate the Addition of two integers");
    Console.WriteLine(" 2. To calculate the Subtraction of two integers");
    Console.WriteLine(" 3. To calculate the Multiplication of two integers");
    Console.WriteLine(" 4. To calculate the Division of two decimals (2 digits rounded)");
    Console.WriteLine(" 5. To calculate the Division of two integers");
    Console.WriteLine(" 6. To calculate the Square of one integer");
    Console.WriteLine(" 7. To play the Random Math Game");

    Console.WriteLine(" 8. To display the scores");
    Console.WriteLine(" 9. To display the previous Math Calculations");
    Console.WriteLine(" 10. To display the previous time lapses for Random Math Games");

    Console.WriteLine();
    Console.WriteLine("Enter your option (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult != null)
    {

        menuSelection = readResult.ToLower();

        if (menuSelection == "11")
        {
            Console.WriteLine("Even or Odd");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number to check if is even or odd, and then press Enter:");
            firstNumberInput = Console.ReadLine();

            // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
            while (!int.TryParse(firstNumberInput, out firstNumber))
            {
                Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                firstNumberInput = Console.ReadLine();
            }
        }
        else if (menuSelection == "6")
        {
            Console.WriteLine("Square Root");

            // Ask the user to type the first number.
            Console.WriteLine("Type a number to Calculate the Square Root, and then press Enter:");
            firstNumberInput = Console.ReadLine();

            // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
            while (!int.TryParse(firstNumberInput, out firstNumber))
            {
                Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                firstNumberInput = Console.ReadLine();
            }
        }
        else if ((menuSelection != "10") && (menuSelection != "9") && (menuSelection != "8") && (menuSelection != "7") && (menuSelection != "6"))
        {
            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter:");
            firstNumberInput = Console.ReadLine();

            // Unhandled exception. System.FormatException: The input string 'a' was not in a correct format.
            while (!int.TryParse(firstNumberInput, out firstNumber))
            {
                Console.WriteLine("This is not a valid input. Please enter a number and then press Enter:");
                firstNumberInput = Console.ReadLine();
            }

            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter:");
            secondNumberInput = Console.ReadLine();

            while (!int.TryParse(secondNumberInput, out secondNumber))
            {
                Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
                secondNumberInput = Console.ReadLine();
            }
        }
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
            Console.WriteLine("Addition");

            questionsToPlay--;
            mathCalculations++;

            MakeSum(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            Console.WriteLine("Subtraction");

            questionsToPlay--;
            mathCalculations++;

            MakeSubtraction(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("Multiplication");

            questionsToPlay--;
            mathCalculations++;

            MakeMultiplication(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("Divion for decimals");

            questionsToPlay--;
            mathCalculations++;

            MakeDivisionForDecimals(firstNumber, secondNumber);

            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("Division for integers");

            questionsToPlay--;
            mathCalculations++;

            MakeDivisionForIntegers(firstNumber, secondNumber);

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("Square Root");

            questionsToPlay--;
            mathCalculations++;

            MakeSquare(firstNumber);

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            questionsToPlay--;

            Console.WriteLine("Random Math Game:");
            Console.WriteLine("Pick the number of questions:");
            readInputResult = Console.ReadLine();
            validEntry = int.TryParse(readInputResult, out rounds);

            var stopWatch = Stopwatch.StartNew();

            while (rounds > 0)
            {
                Console.WriteLine($"Yoy have {rounds} rounds to play");
                GenerateRandomNumbers();
                GenerateRandomGame(firstNumber, secondNumber);
                evenOrOdd(total: firstNumber);
                Console.WriteLine();
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


        case "8":
            Console.WriteLine("Scores:");

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


        case "9":
            Console.WriteLine($"You have done {mathCalculations} Calculations");
            Console.WriteLine();
            Console.WriteLine("Previus Math Calculations:");
            Console.WriteLine();

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

        case "10":
            Console.WriteLine("Previus Lap Times for Random Math Games:");
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

        case "11":
            questionsToPlay--;
            // mathCalculations++;

            evenOrOdd(total: firstNumber);

            Console.WriteLine();
            Console.WriteLine("\n\rPress the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

    }

}

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

void MakeSum(int firstNumber, int secondNumber)
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

    scores[0, 1] = correctAnswerForSum;
    Console.WriteLine();

}

void MakeSubtraction(int firstNumber, int secondNumber)
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

    scores[1, 1] = correctAnswerForSubtraction;
    Console.WriteLine();

}

void MakeMultiplication(int firstNumber, int secondNumber)
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

    scores[2, 1] = correctAnswerForMultiplication;
    Console.WriteLine();

}

void MakeDivisionForDecimals(int firstNumber, int secondNumber)
{
while (secondNumber == 0)
{
Console.WriteLine("Number mustn't be zero. Type another number, and then press Enter:");
secondNumberInput = Console.ReadLine();

        while (!int.TryParse(secondNumberInput, out secondNumber))
        {
            Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
            secondNumberInput = Console.ReadLine();
        }
    }

    rounds--;
    counter++;

    // saving previous calculations
    decimal firstNum = (decimal)firstNumber;
    decimal totalForDivision = firstNum / secondNumber;
    decimal totalRounded = Math.Round(totalForDivision, 2);
    mathGame = String.Format($"{firstNumber} / {secondNumber} = {totalRounded}");
    mathGames[counter] = mathGame;

    Console.WriteLine($"Calculate the Division: {firstNumber} / {secondNumber}");
    readInputResult = Console.ReadLine();
    decimal resultDecimal = 0;
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

void MakeDivisionForIntegers(int firstNumber, int secondNumber)
{
while (secondNumber == 0)
{
Console.WriteLine("Number mustn't be zero. Type another number, and then press Enter:");
secondNumberInput = Console.ReadLine();

        while (!int.TryParse(secondNumberInput, out secondNumber))
        {
            Console.WriteLine("This is not a valid input. Please enter a 1number and then press Enter:");
            secondNumberInput = Console.ReadLine();
        }
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

    scores[3, 1] = correctAnswerForDivision;
    Console.WriteLine();

}

void MakeSquare(int firstNumber)
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

    scores[4, 1] = correctAnswerForSquare;
    Console.WriteLine();

}

void GenerateRandomGame(int firstNumber, int secondNumber)
{
// create some logic to random operations
int randomMathGame = number.Next(mathOperations.Length);

    if (randomMathGame == 1)
    {
        mathCalculations++;
        MakeSum(firstNumber, secondNumber);
    }
    else if (randomMathGame == 2)
    {
        mathCalculations++;
        MakeSubtraction(firstNumber, secondNumber);
    }
    else if (randomMathGame == 3)
    {
        mathCalculations++;
        MakeMultiplication(firstNumber, secondNumber);
    }
    else if (randomMathGame == 4)
    {
        mathCalculations++;
        MakeDivisionForIntegers(firstNumber, secondNumber);
    }
    else
    {
        mathCalculations++;
        MakeSquare(firstNumber);
    }

}

void evenOrOdd(int total)
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
