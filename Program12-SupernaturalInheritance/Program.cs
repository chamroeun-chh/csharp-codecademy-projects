using System;
using System.Net.Http.Headers;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    { 
      Storm [] storms = new Storm[10]; 

      
      Pupil p = new Pupil("Mezil-kree");
      Console.WriteLine(p.CastWindStorm().Announce());

      Mage m = new Mage("Gul'dan");
      Console.WriteLine(m.CastRainStorm().Announce());

      Archmage ar = new Archmage("Nielas Aran");
      Console.WriteLine(ar.CastRainStorm().Announce());
      Console.WriteLine(ar.CastWindStorm().Announce());
      Console.WriteLine(ar.CastLightningStorm().Announce());

      
      
               
    }
  }
}