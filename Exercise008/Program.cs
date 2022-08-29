/* Write a program that picks a random number between 1 and 10.
 * Give the user 4 chances to guess the number.
   If the user guesses the number, display "You won";
   Otherwise display "You Lost"
   (To make sure the program is behaving correctly, you can
    display the secret number on the console first) */

Random random = new Random();
byte randomNumber = (byte) random.Next(1, 11);
byte numberOfGuesses = 0;

/* Testing random number generation */
//for (int i = 0; i < 20; i++)
//{
    //Console.WriteLine(randomNumber);
//}

while (numberOfGuesses < 4)
{
    Console.WriteLine("Guess the random number between 1 & 10.");
    byte userInput = Convert.ToByte(Console.ReadLine());
    numberOfGuesses++;

    if (userInput == randomNumber)
    {
        Console.WriteLine("You Won!");
        break;
    }
    if (numberOfGuesses == 4)
    {
        Console.WriteLine("You Lose!");
        break;
    }
}
