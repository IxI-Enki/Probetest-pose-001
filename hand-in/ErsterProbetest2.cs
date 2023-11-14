namespace ErsterProbetest2
{
  class Program
  {
    static void Main()
    {
      /* VARIABLES: */
      double a = 0, b = 0, c = 0,    ///  declination & initiation of variables x, y, z
             input, swap;            ///  declination of the input and swap variable
      /* INPUT LOOP: */
      for (int i = 1; i <= 3; i++)                       ///  i = counting variable, starting at 0, in increments of 1 (i++),
      {                                                  ///     run as long as i is < 3 .. ( 0-1-2 = loops 3times )
        Console.Write($"\n Wert {i} eingeben:  ");       ///  promt for #i input
        input = Convert.ToDouble(Console.ReadLine());    ///  convert the entered string to double and save it to input
        switch (i)                        ///  switch to different between first, second & third input
        {
          case 1: { a = input; break; }   ///  first input is saved to the variable a
          case 2: { b = input; break; }   ///  second input is saved to the variable b
          case 3: { c = input; break; }   ///  third input is saved to the variable c
        }
      }
      /* CHECK VARIABLES: */
      if (a < b) {    ///  test a - b , if a is smaller -> swap 
        swap = a;
        a = b;
        b = swap;
      }
      if (a < c) {    ///  test a - c , if a is smaller -> swap
        swap = a;
        a = c;
        c = swap;     ///  a now guaranteed to be the biggest number
      }
      if (b < c) {    ///  test b - c , if b is smaller -> swap
        swap = b;
        b = c;
        c = swap;     ///  c now guaranteed to be the smallest value
      }
      /* OUTPUT: */
      Console.Write($"\n größter Wert: {a} " +   ///  output a
        $"\n mittlerer Wert: {b}" +              ///  output b
        $"\n kleinster Wert: {c}");              ///  output c
    }
  }
}
