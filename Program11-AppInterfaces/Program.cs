using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList tdl = new TodoList();

      tdl.Add("[ ] Invite friends");
      tdl.Add("[ ] Buy decorations");
      tdl.Add("[ ] Party");
    
    Console.WriteLine("Todos");
    Console.WriteLine("-----------------");
      tdl.Display();
      tdl.Reset();

      Console.WriteLine("Password");
      Console.WriteLine("-----------------");
      
      // change bool to false to see plaintext password
      PasswordManager pm = new PasswordManager("iluvpie", true);
      
      pm.Display();
      pm.Reset();
      
    }
  }
}
