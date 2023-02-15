// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// // и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

internal class Program
{
  private static void Main(string[] args)
  {
    void GetShowResultDay(int searchDay)
    {
      if (searchDay < 1 || searchDay > 7)
      { Console.Write($"Your day of the week = {searchDay} does not exist"); }
      else
      {
        if (searchDay < 6)
        { Console.Write($"Your day of the week = {searchDay} is not a holiday"); }
        else
        {
          Console.Write($"Your day of the week = {searchDay} is a holiday");
        }
      }
    }
    Console.WriteLine("Enter your number day week");
    int numberWeek = Convert.ToInt32(Console.ReadLine());
    GetShowResultDay(numberWeek);
  }
}