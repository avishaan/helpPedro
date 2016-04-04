// Hello1.cs
public class Hello1
{
   public static void Main()
   {
      string haystack = "Indian.Palace.codehatcher ";

      char splitter = '.';
      string[] needles;
      needles = haystack.Split(splitter);

      foreach (string needle in needles)
      {
        System.Console.WriteLine(needle);
      }
   }

}
