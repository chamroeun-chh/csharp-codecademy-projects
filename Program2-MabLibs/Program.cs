using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program ...
      Author: james wizz
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The program is starting now...");

      // 5
      Console.Write("Please Enter a Name: ");
      string name = Console.ReadLine();

      // 6
     //   1 adj
      Console.Write("Please Enter a Color: ");
      string color = Console.ReadLine();
      
      //   2 adj
      Console.Write("Please Enter a Feeling: ");
      string Feeling = Console.ReadLine();

    // 3 adj
      Console.Write("Please Enter a Texture: ");
      string Texture = Console.ReadLine();
      
      // 8
    //   1 verb
      Console.Write("Please Enter a Action: ");
      string action = Console.ReadLine();

      // 9
    //   1 noun
      Console.Write("Please Enter a Person: ");
      string person = Console.ReadLine();
    //   2 noun 
      Console.Write("Please Enter a place or thing: ");
      string placeOrThing = Console.ReadLine();

      // 10. 
      Console.Write("Please Enter an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Please Enter a food: ");
      string food = Console.ReadLine();

      Console.Write("Please Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Please Enter a superhero: ");
      string superhero = Console.ReadLine();


      Console.Write("Please Enter a country: ");
      string country = Console.ReadLine();


      Console.Write("Please Enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Please Enter a year: ");
      string year = Console.ReadLine();


      // Give the Mad Lib a title:
      // string title = "omg";

      // Define user input and variables:


      // The template for the story:

      string story = $"This morning {name} woke up feeling {color}. 'It is going to be a {Feeling} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {action} to the rhythm of the {person}, which made all the {fruit}s very {Texture}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {placeOrThing}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
