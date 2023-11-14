namespace ErsterProbetest5
{
  class Program
  {
    static void Main()
    {
      /* VARIABLES: */
      int i, j;

      /* LOOP A: */
      Console.Write("\n erste Schleife: ");
      i = 1; j = 1;   ///  start values
      do
      {
        i = i + j;
        j++;
        Console.Write($"\n i={i}  &  j={j} ");
      } while (i < 200);

      /* LOOP B: */
      Console.Write("\n zweite Schleife: ");
      i = 1; j = 20;   ///  start values
      while (i + j < 100)
      {
        i = i + 2;
        j--;
        Console.Write($"\n i:{i}  &  j:{j}  --> i+j:{i+j}");
      }
    }
  }
}
