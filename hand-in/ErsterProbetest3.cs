namespace ErsterProbetest3
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
        case 1:    ///  Jänner
        case 3:    ///  März
        case 5:    ///  Mai
        case 7:    ///  Juli
        case 8:    ///  August
        case 10:    ///  Oktober
        case 12:    ///  Dezember
          days = 31;
          break;
        case 4:    ///  April  
        case 6:    ///  Juni
        case 9:    ///  September
        case 11:    ///  November
          days = 30;
          break;
        case 2:    ///  Februar
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
