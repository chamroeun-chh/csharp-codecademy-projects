// Storm.cs
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;

namespace MagicalInheritance
{
  class Storm
    {
        // automatic properties 
        public string Essence
        { get; private set; } 

        public bool IsStrong
        { get; private set; } 
        public string Caster
        { get; private set; } 


        // Constructor 
        public Storm(string essence, string caster, bool isStrong){
            this.Essence = essence;
            this.Caster = caster;
            this.IsStrong = isStrong; 
        }

        public string Announce() {
            if (IsStrong){
                return $"{Caster} cast a strong {Essence} storm.";
            }
            else 
            {
                return $"{Caster} cast a weak {Essence} storm.";
            }
        }
    


    }

    

    
}
