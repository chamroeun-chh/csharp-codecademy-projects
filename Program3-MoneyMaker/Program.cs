using System.Diagnostics;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {

    // Typeo of coins: 
        // A bronze coin is worth 1 cent
        // A silver coin is worth 5 cents
        // A gold coin is worth 10 cents   
    
    // 1.
      Console.WriteLine("Welcome to Money Maker!");

    // 2. 
    Console.WriteLine("Enter an amount to convert to coins:  ");
    
    // 3. convert string to double 
    double input;
    input = Convert.ToDouble(Console.ReadLine());                 

    // 6. convert to coin          
    double bronze = 1;
    double silver = 5;
    double gold = 10;

    // 7 find max number of gold 
    double goldCoins  = input / gold;
    goldCoins= Math.Floor (goldCoins);

    double silverCoins  = input / silver;
    silverCoins= Math.Floor (silverCoins);
    
    double bronzeCoins  = input / bronze;
    bronzeCoins= Math.Floor (bronzeCoins);

    // 11. PROGRAM 
    Console.WriteLine($"{input} cents is equal to...");
    Console.WriteLine($"Gold coins: {goldCoins}");
    Console.WriteLine($"Silver coins: {silverCoins}");
    Console.WriteLine($"Bronze coins: {bronzeCoins}");

  
    }
  }
}
