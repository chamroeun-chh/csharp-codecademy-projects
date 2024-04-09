using System;
using System.Net.NetworkInformation;

namespace SavingInterface
{
  class PasswordManager: IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

     public void Display(){
            if (Hidden){
                Console.WriteLine("The password is hidden: ********");
            }else{
                Console.WriteLine($"The actual Password is: {Password}");
                
            }              
                
        }
    public void Reset() { 
        Password = "";
        Hidden = false;

    }

  }
}