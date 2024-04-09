using System;
using System.Security.Cryptography.X509Certificates;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957);

      Rover[] rovers = {lunokhod, apollo, sojourner};

      Object[] probes = {lunokhod, apollo, sojourner, sputnik};

      // foreach (Object obj in probes)
      // {
      //   Console.WriteLine($"{obj.GetType()}");
      // }

      IDirectable[] directables = {lunokhod, apollo, sojourner, sputnik};
      
      // 9.
      DirectAll(directables);



      

    // 2.  
    // DirectAll(rovers);
    }

    // public static void DirectAll(Rover[] rovers) {
    //     foreach (Rover r in rovers)
    //     {
    //       Console.WriteLine(r.GetInfo());
    //       Console.WriteLine(r.Explore());
    //       Console.WriteLine(r.Collect());
    //     }
    // }


    public static void DirectAll(IDirectable[] directables) {
        foreach (IDirectable i in directables)
        {
          Console.WriteLine(i.GetInfo());
          Console.WriteLine(i.Explore());
          Console.WriteLine(i.Collect());
        }
    }
  }
}
