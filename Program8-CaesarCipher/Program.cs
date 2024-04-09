using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("Please input secret message: ");
      string DefaultInput = Console.ReadLine();
      string input = DefaultInput.ToLower();

      char[] secretMessage = input.ToCharArray(); 
      char[] encryptedMessage  = new char[secretMessage.Length];

   for(int i=0; i < secretMessage.Length; i++ ){
    char letter = secretMessage[i];
   
    int characterPosition = Array.IndexOf(alphabet, letter);
    int newCharacterPosition = (characterPosition +3) % alphabet.Length;  

    char newEncryptedCharacter = alphabet[newCharacterPosition]; 
    encryptedMessage[i] = newEncryptedCharacter;
    
      }

      string msgString = String.Join("",encryptedMessage);
      Console.WriteLine($"Your encryped message is: {msgString}");



      

      

    
   





       

      
    }
  }
}