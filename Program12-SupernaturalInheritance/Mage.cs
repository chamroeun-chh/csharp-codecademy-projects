// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {

    // used base so we can inherit from constructor pupil
    public Mage(string title) : base(title)
    {}
    
    public virtual Storm CastRainStorm(){
        return new Storm("Rain",Title,false);  
    }

    
  }
}
