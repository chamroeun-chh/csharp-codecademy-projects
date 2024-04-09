using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace PasswordChecker
{
  class Program
  {
    private static bool Contains(string str, string characters){
    foreach (char c in characters){
        if (str.Contains(c)){
            return true;
        }
    }
    return false;
  }
    public static void Main(string[] args)
    {
// program that measures the strength of any given password based on the following criteria. 

// A strong password:
// is at least 8 characters long
// has lowercase letters
// has uppercase letters
// has numerical digits
// has symbols, like #, ?, !


    // 1. setup 
    int miniLength = 8;
    string uppercase="ABCDEFGHIJKLMNOPQRSTUVWXYZ"; 
    string lowercase="abcdefghijklmnopqrstuvwxyz"; 
    string digits="0123456789";
    string specialChars="!@#$%^&*()-_+=\\/':,{}[]~.";


    // 2.
    Console.Write("Please input a password: ");
    string password = Console.ReadLine();
      
    // 3. test 
    int score = 0; 

    // 4. 
    if (password.Length >= miniLength) { 
        score += 1; 
    }

    // 5.
    if(Contains(password, uppercase)){
        score += 1;
    }
    
    // 6. 
    if(Contains(password, lowercase)){
        score += 1;
    }
    
    // 7.
    if(Contains(password, digits)){
        score += 1;
    }

    // 8. 
    if(Contains(password, specialChars)){
        score += 1;
    }

    // 9.
    // Console.WriteLine($"the score of this password {password} is {score}/5");

    // Tell the User
    // 10.
    switch(score){
        case 5: 
        Console.WriteLine($"{password} scores a {score}/5. Extremely strong again!");
        break;

        case 4: 
        Console.WriteLine($"{password} scores a {score}/5. Extremely strong!");
        break;


        case 3: 
        Console.WriteLine($"{password} scores a {score}/5. Strong.");
        break;


        case 2: 
        Console.WriteLine($"{password} scores a {score}/5. Medium.");
        break;


        case 1: 
        Console.WriteLine($"{password} scores a {score}/5. Weak.");
        break;
        
        case 0: 
        Console.WriteLine($"{password} scores a {score}/5. t’s a bunch of spaces. It doesn’t meet any of the standards.");
        break;
        
        default:
        Console.WriteLine("Invalid password. Try again!"); 
    break;
    
    } 

    }
  }
  
}
