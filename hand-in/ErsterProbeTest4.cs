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
      a3 = a; b3 = b; c3 = c;       ///  save variables for a third codeblock
      /* ORIGINAL CODE: */
      if (b == 0)
      { a = 2 * c; }
      else if (c != 0)
      { a = a * b + 2 * c; }
      else
        a = a * b;
      Console.Write($"\n Wert a: {a} \n\n Neuer Code:  ");   ///  output a:34
      /* SHORTENED CODE */
      if (b2 == 0)
      { a2 = 2 * c2; }
      else
      { a2 = a2 * b2;
        if (c2 != 0)
        { a2 = a2 + 2 * c2; } }
      Console.Write($"\n Wert a2: {a2} \n\n Neuester Code:  ");   ///  output a:34
      /* EVEN SHORTER CODE */
      a3 = (b3 == 0) ? 2 * c3 : (c3 != 0) ? a3 * b3 + 2 * c3 : a3 * b3; 
      Console.Write($"\n Wert a3: {a3}");   ///  output a:34
    }
  }
}
