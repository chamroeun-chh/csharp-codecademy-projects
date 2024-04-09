using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */
    // Set Up the Program
      // Start by asking for the user's name:
      Console.Write("What is your name? ");

    
    // 1.
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
    
    // 2. 
    string story = "It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?";

    // 3.
    Console.Write("Type YES or NO: ");
    
    // 4.
    string noiseChoice = Console.ReadLine();
    // 5.
    string firstChoice = noiseChoice.ToUpper();
    
    // 6. dotnet run 
    Console.WriteLine(firstChoice);

    // Adding Conditional Statements
    // 7.
    if(firstChoice == "NO"){
      Console.WriteLine("Not much of an adventure if we don't leave our room!");
      Console.WriteLine("THE END.");
      
      // 8,9
    } else if (firstChoice == "YES"){
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
      Console.WriteLine("You walk towards it. Do you open it or knock?");
      
      // 10,=.
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine();
      string doorChoiceUpper = doorChoice.ToUpper();

      // 11.
      if(doorChoiceUpper == "KNOCK"){
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\n" + 
"\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
        Console.Write("Type your answer: ");
        string riddleAnswerDefault = Console.ReadLine();
        string riddleAnswer = riddleAnswerDefault.ToUpper();

        if (riddleAnswer == "NOTHING"){
          Console.WriteLine("The door opens and NOTHING is there.\n You turn off the light and run back to your room and lock the door.\n THE END.");
        } else {
          Console.WriteLine("You answered incorrectly. The door doesn't open.\n THE END.");
        }

      }else if(doorChoiceUpper == "OPEN"){
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("Enter a number (1-3): "); 
        string keyChoiceDefault = Console.ReadLine();
        string keyChoice = keyChoiceDefault.ToUpper();

        switch (keyChoice){
          case "1": 
          Console.WriteLine("You choose the first key. Lucky choice!\n The door opens and NOTHING is there. Strange...\n THE END.");
          break;

          case "2": 
          Console.WriteLine("You choose the second key. The door doesn't open. \n THE END.");
          break;

          case "3": 
          Console.WriteLine("You choose the third key. The door doesn't open. \n THE END.");
          break;

          default:
          Console.WriteLine("Invalid Number. \n THE END.");
          break;

          
        }


      }


      // Adding a Switch Statement











      
    }





     
    }
  }
}



