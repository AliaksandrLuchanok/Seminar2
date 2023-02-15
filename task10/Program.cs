// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

internal class Program
{
  private static void Main(string[] args)
  {
    // 456 -> 5
    // 782 -> 8
    // 918 -> 1
    int GetsecondNumber(int numberOfFreeNumbers)
    {
      return (numberOfFreeNumbers / 10) % 10;
    }

    Console.WriteLine("Enter your three digit number");
    int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
    if (threeDigitNumber > 99 && threeDigitNumber < 1000)
    { Console.WriteLine($"Your secondNumber = {GetsecondNumber(threeDigitNumber)}"); }
    else {Console.WriteLine($"Your numbers = {threeDigitNumber} does not match input parameters");}
  }
}




