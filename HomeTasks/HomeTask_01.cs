// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Lecture 8. Вычисление среднего арифметического двух чисел
/* Console.WriteLine("Please enter the first number:");

double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number:");

double number2 = double.Parse(Console.ReadLine());
double avarage = (number1 + number2) / 2;

Console.WriteLine($"The avarage of {number1} and {number2} is {avarage}"); */


//Введите три числа и выведите на экран значение суммы и произведения этих чисел.
/* Console.WriteLine("Please enter the first number:");

double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number:");

double number2 = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the third number:");

double number3 = double.Parse(Console.ReadLine());

double sum = number1 + number2 + number3;

double multiplication = number1 * number2 * number3;

Console.WriteLine($"The sum of {number1}, {number2} and {number3} is {sum}");
Console.WriteLine($"The multiplication of {number1}, {number2} and {number3} is {multiplication}"); */


//Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем). Вылюты заданы хардкодом
//и не изменяются. Тип валют на выбор программиста.
/* Console.WriteLine("This is currency converter.\nPlease enter the amount of PLN you would like to convert:");

double number1 = double.Parse(Console.ReadLine());

double EURSell = 4.3324;
double USDSell = 4.0082;
double GBPSell = 5.1960;
double CHFSell = 4.6460;

double EURSellToWithdraw = Math.Round(number1 / EURSell, 2);
double USDSellToWithdraw = Math.Round(number1 / USDSell, 2);
double GBPSellToWithdraw = Math.Round(number1 / GBPSell, 2);
double CHFSellToWithdraw = Math.Round(number1 / CHFSell, 2);

Console.WriteLine($"You can convert {number1} PLN to:\n{EURSellToWithdraw} EUR\n{USDSellToWithdraw} USD\n{GBPSellToWithdraw} GBP\n{CHFSellToWithdraw} CHF"); */


//Напишите программуу, проверяющую число, введенное с клавиатуры на четность.
/* Console.WriteLine("Please enter the number: ");

double userValue = double.Parse(Console.ReadLine());

if (userValue % 2 == 0   )
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
} */


//Напишите простейший калькулятор
//Option #1
/* Console.WriteLine("Please enter the first number:");

double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number:");

double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("What arithmetic operation do you want to perform with these numbers?\nEnter \"+\" for addition, \"-\" for subtraction, \"*\" for multiplication and \"/\" for division:");

string arithmeticOperation = Console.ReadLine();

switch (arithmeticOperation)
{
    case "+":
        double additionResult = firstNumber + secondNumber;
        Console.WriteLine($"The result of adding the numbers {firstNumber} and {secondNumber} is the number {additionResult}.");
        break;

    case "-":
        double subtractionResult = firstNumber - secondNumber;
        Console.WriteLine($"The result of subtraction the numbers {firstNumber} and {secondNumber} is the number {subtractionResult}.");
        break;

    case "*":
        double multiplicationResult = firstNumber * secondNumber;
        Console.WriteLine($"The result of multiplication the numbers {firstNumber} and {secondNumber} is the number {multiplicationResult}.");
        break;

    case "/":
        if (secondNumber != 0)
        {
            double divisionResult = firstNumber / secondNumber;
            Console.WriteLine($"The result of division the numbers {firstNumber} and {secondNumber} is the number {divisionResult}.");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        break;
  
    default:
        Console.WriteLine("Unrecognized arithmetic operation.");
        break;

} */

//Option #2
/* Console.WriteLine("Please enter the first number:");

double firstNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Please enter the second number:");

double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine("What arithmetic operation do you want to perform with these numbers?\nEnter \"+\" for addition, \"-\" for subtraction, \"*\" for multiplication and \"/\" for division:");

string arithmeticOperation = Console.ReadLine();

if (arithmeticOperation == "+")
{
    double additionResult = firstNumber + secondNumber;
    Console.WriteLine($"The result of adding the numbers {firstNumber} and {secondNumber} is the number {additionResult}.");
}
else if (arithmeticOperation == "-")
{
    double subtractionResult = firstNumber - secondNumber;
    Console.WriteLine($"The result of subtraction the numbers {firstNumber} and {secondNumber} is the number {subtractionResult}.");
}
else if (arithmeticOperation == "*")
{
    double multiplicationResult = firstNumber * secondNumber;
    Console.WriteLine($"The result of multiplication the numbers {firstNumber} and {secondNumber} is the number {multiplicationResult}.");

}
else if (arithmeticOperation == "/")
{
    if (secondNumber != 0)
    {
        double divisionResult = firstNumber / secondNumber;
        Console.WriteLine($"The result of division the numbers {firstNumber} and {secondNumber} is the number {divisionResult}.");
    }
    else
    {
        Console.WriteLine("Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Unrecognized arithmetic operation.");
} */


//Подсчитать количество четных и нечетных чисел в диапазоне, который указывает пользователь.

/* Console.WriteLine("Please enter the lower limit of the range:");
int lowerRangeLimit = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter the upper limit of the range:");
int upperRangeLimit = int.Parse(Console.ReadLine());

int counter = lowerRangeLimit;

int evenCounter = 0;
int oddCounter = 0;

while (counter <= upperRangeLimit)
{

    if (counter % 2 == 0)
        evenCounter++;
    else
        oddCounter++;

    counter++;
}

Console.WriteLine($"Quantity of even numbers is {evenCounter}");
Console.WriteLine($"Quantity of odd numbers is {oddCounter}"); */


/* //При помощи вложенных циклов необходимо отрисовать в консоли треугольники: первый - высота 10 строк, ширина от 1 до 10 символов
//и через 3 пустые второй - высота 10 строк, ширина от 10 до 1 символов

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine("");

}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    for (int j = i; j < 10; j++)
    {
        Console.Write("#");
    }

    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    for (int k = 0; k < 9 - i; k++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j <= i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine("");

}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

for (int i = 0; i < 10; i++)
{
    for (int k = 1; k < i + 1; k++)
    {
        Console.Write(" ");
    }

    for (int j = i; j < 10; j++)
    {
        Console.Write("#");
    }

    Console.WriteLine("");
} */


//Заполнение массива с клавиатуры
/* int[] myArray = new int[5];

Console.WriteLine("Please enter 5 integers for array:");

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\n The array in the reversed order:"); */

/* //Вывод массива в обратном порядке
for (int i = myArray.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{myArray[i]}");
}

//Сумма четных чисел в массиве.
int sumOfEvenNumbers = 0;

foreach (var item in myArray)
{
    //if (item % 2 == 0)
    //{
    //    sumOfEvenNumbers += item;
    //}

    sumOfEvenNumbers += item % 2 == 0 ? item : 0;
}

Console.WriteLine($"\nThe sum of even numbers in the array: {sumOfEvenNumbers}");

//Найти наименьшее число в в массиве.
int smallestNumberInArray = myArray[0];

foreach (var item in myArray)
{
    //if (item < smallestNumberInArray)
    //   smallestNumberInArray = item;

    smallestNumberInArray = item < smallestNumberInArray ? item : smallestNumberInArray;
}

Console.WriteLine($"\nThe smallest number in the array: {smallestNumberInArray}"); */

/* Temperature Analysis
Write a program that accepts an array of daily temperatures for a month and performs the following actions:

Calculates the average temperature for the month.
Finds the minimum and maximum temperatures.
Outputs the number of days when the temperature was above the average.
Determines the longest period with positive temperatures (consecutive days with temperatures above zero). */

/* int[] dailyTemperaturesForMonth = [5, -2, 3, -1, 6, 7, -4, 3, 2, -5, -3, 4, 5, 6];

//the average temperature for the month
// double avarageTemperatureForMonth = 0;
// double sumOfTemperaturesForMonth = 0;

// for (int i = 0; i < dailyTemperaturesForMonth.Length; i++)
// {
//     sumOfTemperaturesForMonth += dailyTemperaturesForMonth[i];
// }

// avarageTemperatureForMonth = sumOfTemperaturesForMonth / dailyTemperaturesForMonth.Length;

double avarageTemperatureForMonth = dailyTemperaturesForMonth.Average();

Console.WriteLine($"The average temperature for the month: {avarageTemperatureForMonth:F2}");

//the minimum temperature
// int minimumTemperature = dailyTemperaturesForMonth[0];

// for (int i = 0; i < dailyTemperaturesForMonth.Length; i++)
// {
//     if (minimumTemperature > dailyTemperaturesForMonth[i])
//     minimumTemperature = dailyTemperaturesForMonth[i];
// }

int minimumTemperature = dailyTemperaturesForMonth.Min();

Console.WriteLine($"The minimum temperature: {minimumTemperature}");

//the maximum temperature
int maximumTemperature = dailyTemperaturesForMonth[0];

foreach (var item in dailyTemperaturesForMonth)
{
    maximumTemperature = maximumTemperature < item ? item : maximumTemperature;
}

Console.WriteLine($"The maximum temperature: {maximumTemperature}");

//Outputs the number of days when the temperature was above the average
int daysAboveAvarage = 0;

for (int i = 0; i < dailyTemperaturesForMonth.Length; i++)
{
    daysAboveAvarage += dailyTemperaturesForMonth[i] > avarageTemperatureForMonth ? 1 : 0;
}

Console.WriteLine($"The number of days when the temperature was above the average: {daysAboveAvarage}");

//Determines the longest period with positive temperatures (consecutive days with temperatures above zero)
int periodOfDaysAboveZero = 0;
int daysCounter = 0;

for (int i = 0; i < dailyTemperaturesForMonth.Length; i++)
{
    if (dailyTemperaturesForMonth[i] > 0)
    {
        daysCounter++;
        periodOfDaysAboveZero = daysCounter >= periodOfDaysAboveZero ? daysCounter : periodOfDaysAboveZero;
    }
    else
    {        
        daysCounter = 0;
    }
}

Console.WriteLine($"The longest period with positive temperatures: {periodOfDaysAboveZero}"); */


/* Fibonacci Numbers
Write a program that asks the user for the number of Fibonacci sequence numbers to generate and stores them in an array. Then:

Print all elements of the array.
Find the sum of even numbers in the array.
Find the difference between the largest and smallest elements in the array. */

/* // Print all elements of the array.
int userInput = 0;

Console.WriteLine("Enter the number of Fibonacci numbers:");

userInput = int.Parse(Console.ReadLine());

int[] fibonacciNumbers = new int[userInput];
if (fibonacciNumbers.Length > 1)
    fibonacciNumbers[1] = 1;

for (int i = 2; i < userInput; i++)
{
    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
}

Console.WriteLine($"Fibonacci numbers:");

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}

// Find the sum of even numbers in the array.
int sumEvenNumbers= 0;

for (int i = 0; i < fibonacciNumbers.Length; i++)
{
    sumEvenNumbers += fibonacciNumbers[i] % 2 == 0 ? fibonacciNumbers[i] : 0;
}

Console.WriteLine($"The sum of even numbers in the array: {sumEvenNumbers}");

// Find the difference between the largest and smallest elements in the array.

int largestMinusSmallest = fibonacciNumbers[^1] - fibonacciNumbers[0];

Console.WriteLine($"The difference between the largest and smallest elements in the array: {largestMinusSmallest}"); */


/* Counting Vowels and Consonants
Write a program that accepts a string and counts the number of vowels and consonants.
Then, output the most frequently occurring letters and the number of words in the string. */

/* string input = "Programming in C# is fun and interesting!".ToLower();

char[] vowels = ['a', 'e', 'i', 'o', 'u'];

char[] consonants = ['b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'];

int numberVowels = 0;

int numberConsonants = 0;

for (int i = 0; i < input.Length; i++)
{
    if (Char.IsLetter(input[i]))
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (input[i] == vowels[j])
            {
                numberVowels++;
                break;
            }
        }

        for (int k = 0; k < consonants.Length; k++)
        {
            if (input[i] == consonants[k])
            {
                numberConsonants++;
                break;
            }
        }
    }
}

string[] wordsArray = input.Split(' ');

int numberWords = wordsArray.Length;

Console.WriteLine($"Number of vowels: {numberVowels}");
Console.WriteLine($"Number of consonants: {numberConsonants}");
//для решения надо использовать двумерный массив?
Console.WriteLine($"Most frequent letters:");
Console.WriteLine($"Number of words: {numberWords}"); */


/* "Guess the Number" Game
Create a game where the program randomly selects a number from 1 to 100. The user should try to guess this number.
The program should:

Inform the user if their guess is too low or too high.
Count the number of attempts made by the user to guess the number.
Ask the user if they want to play again after the game ends. */

/* int userInput = 0;

int attemptsCounter = 0;

bool wantToPlay = true;

while (wantToPlay)
{
    int numberToGuess = new Random().Next(1, 101);

    Console.WriteLine("A number from 1 to 100 has been chosen. Try to guess it!");

    do
    {
        userInput = int.Parse(Console.ReadLine());

        attemptsCounter++;

        Console.WriteLine($"Your guess: {userInput}");

        if (userInput > numberToGuess)
        {
            Console.WriteLine("Too high!");
        }
        else if (userInput < numberToGuess)
        {
            Console.WriteLine("Too low!");
        }
        else
        {
            Console.WriteLine($"Correct! Number of attempts: {attemptsCounter}");
            Console.WriteLine("Would you like to play again? (yes/no)");

            if (Console.ReadLine() != "yes")
            {
                wantToPlay = false;
            }
        }

    } while (userInput != numberToGuess);
} */


/* Arrays and Sorting
Write a program that:

Asks the user for an array size and fills it with random numbers from -50 to 50.
Sorts the array in ascending order and prints it.
Finds the median of the array (average of two middle elements for an even number of elements or the middle element for an odd number).
Outputs elements of the array that are divisible by 3. */

/* //Sorts the array in ascending order
int arraySize = 0;

Console.WriteLine("Enter array size:");

arraySize = int.Parse(Console.ReadLine());

int[] randomArray = new int[arraySize];

Random random = new();

for (int i = 0; i < arraySize; i++)
{
    randomArray[i] = random.Next(-50, 51);
}

Array.Sort(randomArray);

Console.WriteLine($"The array in ascending order: {string.Join(", ", randomArray)}");

//Finds the median of the array (average of two middle elements for an even number of elements or the middle element for an odd number)
double median = 0;

if (randomArray.Length % 2 == 0)
{
    median = (randomArray[(randomArray.Length / 2) - 1] + randomArray[(randomArray.Length / 2)]) / 2.0;
}
else
{
    median = randomArray[randomArray.Length / 2];
}

Console.WriteLine($"The median of the array: {median}");

//Outputs elements of the array that are divisible by 3
Console.WriteLine("Elements of the array that are divisible by 3:");

for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] % 3 == 0)
    {
        Console.Write(randomArray[i] + " ");
    }
} */

/* Searching in an Array with Conditions
Write a program that:

Checks if the array contains at least one negative number.
Outputs all numbers that are divisible by both 2 and 5.
Finds all unique numbers in the array (no repetitions). */

/* //Checks if the array contains at least one negative number.
int[] userInput = [5, 10, -3, 20, 15, 10, -6, 30];

for (int i = 0; i < userInput.Length; i++)
{
    if (userInput[i] < 0)
    {
        Console.WriteLine("The array contains at least one negative nummber.\n");
        break;
    }
}

//Finds all unique numbers in the array (no repetitions).
int[] distinctNumbers = userInput.Distinct().ToArray();

Console.WriteLine($"Unique numbers in the array: {string.Join(", ", distinctNumbers)}\n");

//Outputs all numbers that are divisible by both 2 and 5.
int[] divisibleBy2And5 = new int[0];

Console.Write("Numbers divisible by 2 and 5: ");

for (int i = 0; i < distinctNumbers.Length; i++)
{
    if ((distinctNumbers[i] % 2 == 0) && (distinctNumbers[i] % 5 == 0))
    {
        Console.Write($"{distinctNumbers[i] + " "}");
    }
}

Console.WriteLine("\n"); */


// 1.	Написать функцию которая выводит на экран строку. Символы из которых состоит строка и их количество вводятся пользователем.
/* int numberOfSymbols = 0;

Console.WriteLine("How many symbols would you like to enter?");

numberOfSymbols = int.Parse(Console.ReadLine());

string[] userInput = new string[numberOfSymbols];

Console.WriteLine("Please enter symbols:");

for (int i = 0; i < numberOfSymbols; i++)
{
    userInput[i] = Console.ReadLine();
}

string stringFromArray(string[] input)
{
    return String.Join(" ", input);
}

Console.WriteLine($"The string from user input: {stringFromArray(userInput)}"); */

// 2.	Написать метод для поиска индекса элемента массива (тип элементов в массиве -int), метод должен вернуть индекс
// первого найденного элемента (если он будет найден).

/* int[] input = [5, 10, 0, -45, 78, 125, -1, 1482, 5, 78, 14];

bool userNeedsIndex = true;

do
{
    Console.WriteLine("Would you like to find an index of any element of the array? (Yes or No)");

    string userAnswer = Console.ReadLine().ToLower();

    if (userAnswer == "yes")
    {
        Console.WriteLine($"Here is the array: {String.Join(", ", input)}");
        Console.WriteLine("Please select any number from the array:");

        int userNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"The index of number {userNumber} is {findIndexOfNumber(userNumber, input)}");
        break;
    }
    else if (userAnswer == "no")
    {
        Console.WriteLine("Bye.");
        userNeedsIndex = false;
        //break;
    }
    else
    {
        Console.WriteLine("Unrecognized input. Restarting the programm.");

    }
} while (userNeedsIndex);

static int findIndexOfNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            return i;
        }
    }

    return -1;
} */


// Task 1: Null Coalescing Operator (??)
// Write a method GetDefaultName that takes a nullable string parameter inputName.
// If inputName is null, return "Guest".
// Otherwise, return the value of inputName.

/* static string GetDefaultName(string inputName)
{
    return inputName ?? "Guest";
}

Console.WriteLine(GetDefaultName(null)); */


// Task 2: Null Coalescing Assignment Operator (??=)
// Write a method SetDefaultName that takes a nullable string parameter name.
// If name is null, assign it the value "Default Name" using the ??= operator.
// Print the value of name.

/* static string SetDefaultName(string? name)
{
    return name ??= "Default name";
}

Console.WriteLine(SetDefaultName(null)); */


// Task 3: Null Conditional Operator (?.)
// Write a method GetFirstCharacter that takes a nullable string input.
// Use the null conditional operator to return the first character of the string if input is not null.
// Otherwise, return null.

/* static char? GetFirstCharacter(string? input)
{
    return input?[0] ?? 'd';
}

Console.WriteLine(GetFirstCharacter(null)); */