namespace ErsterProbetest4
{
  class Program
  {
    static void Main()
    {    /// VARIABLES:
      int a,  b,  c,                ///  input: a:3 , b:8 , c:5
          a2, b2, c2;
      Console.Write("\n Wert a eingeben:  ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.Write("\n Wert b eingeben:  ");
      b = Convert.ToInt32(Console.ReadLine());
      Console.Write("\n Wert c eingeben:  ");
      c = Convert.ToInt32(Console.ReadLine());
      a2 = a; b2 = b; c2 = c;       ///  save variables for a second codeblock
      /* ORIGINAL CODE: */
      if (b == 0)
      { a = a * c; }
      else if (c != 0)
      { a = a * b + 2 * c; }
      else
        a = a * b;
      Console.Write($"\n Wert a: {a} \n\n Neuer Code:  ");   ///  output a:34
      /* SHORTENED CODE */
      if (b2 == 0)
      { a2 = a2 * c2; }
      else
      { a2 = a2 * b2;
        if (c2 != 0)
        { a2 = a2 + 2 * c2; } }
      Console.Write($"\n Wert a: {a}");   ///  output a:34
    }
  }
}
