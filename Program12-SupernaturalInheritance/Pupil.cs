// Pupil.cs
using System;
using System.Reflection;

namespace MagicalInheritance
{
 class Pupil
 {
    // properties 
    public string Title
    {get; private set;}

    // constructor 
    public Pupil (string title){
        this.Title = title; 
    }

    public virtual Storm CastWindStorm(){
        return new Storm ("wind", Title, false);
         

    }
 }
}
