// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
internal class Program
{
  private static void Main(string[] args)
  {
    // 456 -> 5
    // 782 -> 8
    // 918 -> 1
    int GetFreeNumber(int searchForTheThirdNumber)
    { while (searchForTheThirdNumber > 999)
      {searchForTheThirdNumber = searchForTheThirdNumber/10;}
       return searchForTheThirdNumber%10;
    }

    Console.WriteLine("Enter your number");
    int Number = Convert.ToInt32(Console.ReadLine());
    if (Number < 100)
    {Console.WriteLine($"Your number = {Number} does not contain a third number");}
    else
    {
      Console.WriteLine($"Your FreeNumber = {GetFreeNumber(Number)}");
      }
  }
}




