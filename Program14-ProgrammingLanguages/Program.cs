using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

        foreach(var p in languages ) {
            // Console.WriteLine(p.Prettify());
        }

        var data = languages.Select (x=>$"{x.Year},{x.Name},{x.ChiefDeveloper},{x.Predecessors}");


        // foreach (var item in data)  
        // {
        //     Console.WriteLine(item);
        // }

        var csharp = languages.Where(x => x.Name == "C#"); 

        // foreach (var c in csharp)
        // {
        //     Console.WriteLine(c.Prettify());
        // }

        var microsoft = languages.Where(x => x.ChiefDeveloper.Contains("Microsoft"));  
        
        // foreach (var c in microsoft )
        // {
        //     Console.WriteLine(c.Prettify());
        // }

        var lisp = languages.Where(x=> x.Predecessors.Contains("Lisp"));
        
        // foreach (var lisps in lisp)
        // {
        //     Console.WriteLine(lisps.Prettify());
        // }
         
        var Script = languages
            .Where(x => x.Name.Contains("Script"))
            .Select(x => x.Name);

        // foreach (var name in Script)
        // {
        //     Console.WriteLine(name);
        // }

        // Console.WriteLine($"There are {languages.Count} languages");
        
        var countOldLang = languages
        .Where(x=> x.Year >=1995 && x.Year <=2005)
        .Select(x => $"{x.Name} was invented in {x.Year}");

        // Console.WriteLine($"Between 1995 and 2005 there are {countOldLang.Count()} languages");
        
        // foreach (var collection in countOldLang)
        // {
        //     Console.WriteLine(collection);
        // }
 
        // PrettyPrintAll(microsoft);
        // PrintAll(countOldLang);
        

        

    }

    public static void PrettyPrintAll(IEnumerable<Language> languages) {
        foreach (Language lang in languages)    
        {
            Console.WriteLine(lang.Prettify());
        }
    }

    public static void PrintAll(IEnumerable<Object> sequence) {
        foreach (Object obj in sequence){
            Console.WriteLine(obj);
        }
    }
  }
}

 