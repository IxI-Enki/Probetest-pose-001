namespace ErsterProbetest1
{
  class Program
  {
    static void Main()
    {
      /* VARIABLES: */
      double x = 0, y = 0, z = 0,    ///  declination & initiation of variables x, y, z
            input;                   ///  declination of the input variable
      /* INPUT LOOP: */
      for (int i = 0; i < 3; i++)                       ///  i = counting variable, starting at 0, in increments of 1 (i++),
      {                                               ///     run as long as i is < 3 .. ( 0-1-2 = loops 3times )
        Console.Write($"\n Wert {i} eingeben:  ");           ///  promt for #i input
        input = Convert.ToDouble(Console.ReadLine());     ///  convert the entered string to double and save it to input
        switch (i)                         ///  switch to different between first, second & third input
        {
          case 1: { x = input; break; }   ///  first input is saved to the variable x
          case 2: { y = input; break; }   ///  second input is saved to the variable y
          case 3: { z = input; break; }   ///  third input is saved to the variable z
        }
      }
      /* CHECK VARIABLES: */
      if ((x != z) && (x != y) && (y != z))                  ///  test the three inputs against each other, if all three 
      /* OUTPUT: */
      {                                                   ///    are different from another, the IF branch is executed
        Console.WriteLine("\n 3 verschiedene Werte, toll!");        ///  output the "TOLL" message
      }
      else Console.WriteLine("\n mindestens 2 gleiche Werte.");    ///  else:  output the "GLEICHE WERTE" branch
    }
  }
}
