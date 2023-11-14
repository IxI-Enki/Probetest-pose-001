---  
#  *Verzeichniss mit den Abgaben*  
  
---  
###  *Abgabe.preview:*  

## *1*)  

``` c#
﻿namespace ErsterProbetest1
{
  class Program
  {
    static void Main()
    {
      /* VARIABLES: */
      double x = 0, y = 0, z = 0,     ///  declination & initiation of variables x, y, z
             input;                   ///  declination of the input variable
      /* INPUT LOOP: */
      for (int i = 0; i < 3; i++)                        ///  i = counting variable, starting at 0, in increments of 1 (i++),
      {                                                  ///     run as long as i is < 3 .. ( 0-1-2 = loops 3times )
        Console.Write($"\n Wert {i} eingeben:  ");       ///  promt for #i input
        input = Convert.ToDouble(Console.ReadLine());    ///  convert the entered string to double and save it to input
        switch (i)                        ///  switch to different between first, second & third input
        {
          case 1: { x = input; break; }   ///  first input is saved to the variable x
          case 2: { y = input; break; }   ///  second input is saved to the variable y
          case 3: { z = input; break; }   ///  third input is saved to the variable z
        }
      }
      /* CHECK VARIABLES: */
      if ((x != z) && (x != y) && (y != z))               ///  test the three inputs against each other, if all three 
      /* OUTPUT: */                                       ///    are different from another, the IF branch is executed
      {
        Console.WriteLine("\n 3 verschiedene Werte, toll!");       ///  output the "TOLL" message
      }
      else Console.WriteLine("\n mindestens 2 gleiche Werte.");    ///  else:  output the "GLEICHE WERTE" branch
    }
  }
} 
  
```

## *2*)  

``` c#
﻿namespace ErsterProbetest2
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
```

## *3*)

``` c#
﻿namespace ErsterProbetest3
{
  class Program
  {
    static void Main()
    {
      /* VARIABLES: */
      int days, month;

      Console.Write($"\n Monat (1-12) eingeben:  ");          
      month = Convert.ToInt32(Console.ReadLine());
      switch (month)                       
      {
        case 1:     ///  Jänner
        case 3:     ///  März
        case 5:     ///  Mai
        case 7:     ///  Juli
        case 8:     ///  August
        case 10:    ///  Oktober
        case 12:    ///  Dezember
          days = 31;
          break;
        case 4:     ///  April  
        case 6:     ///  Juni
        case 9:     ///  September
        case 11:    ///  November
          days = 30;
          break;
        case 2:     ///  Februar
          days = 28;
          break;
        default:
          days = -1;
          break;
      }
      if (days == -1)
      {
        Console.Write("\n ungültige Eingabe! ");
      }
      else
        Console.WriteLine($"\n Der {month}. Monat hat {days}Tage. ");
    }
  }
}
```

## *4*) 

``` c#
﻿namespace ErsterProbetest4
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

```

## *5*)
  
``` c#
﻿namespace ErsterProbetest5
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
      Console.Write($"\n Schleife A terminiert! \n");

      /* LOOP B: */
      Console.Write("\n zweite Schleife: ");
      i = 1; j = 20;   ///  start values
      while (i + j < 100)
      {
        i = i + 2;
        j--;
        Console.Write($"\n i:{i}  &  j:{j}  --> i+j:{i+j}");
      }
      Console.Write($"\n Schleife B terminiert! \n");
    }
  }
}

```

## *6*)
  
``` c#


```
