// Archmage.cs
using System;

namespace MagicalInheritance
{
 class Archmage : Mage
 {     
    // used base so we can inherit from constructor Mage
    public Archmage(string title) : base(title){}

    public override Storm CastRainStorm(){
        return new Storm("rain", Title, true);
    }

    public override Storm CastWindStorm(){
        return new Storm("wind", Title, true);
    }

    public Storm CastLightningStorm(){
        return new Storm("lighting", Title, true);
    }





    
 }
}
