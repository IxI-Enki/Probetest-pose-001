namespace ErsterProbetest6
{
  class Program
  {
    static void Main()
    {
      /* VARIABLES: */
      int n,
         i = 1;
      /* INPUT: */
      Console.Write("\n positive Ganzzahl eingeben:  ");
      n = Convert.ToInt32(Console.ReadLine());
      /* CALCULATION: */
      while (n / 10 != 0)
      {
        i++;
        n = n / 10;
      }
      /* OUTPUT: */
      Console.Write($"\n Die Zahl hatte: {i}Stellen. ");
    }
  }
}
