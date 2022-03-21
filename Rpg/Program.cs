using System;
using Rpg.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {

            RpgContext rpg = new RpgContext();
           
            var arus1 = new Arus("The Wizard", 100, HeroType.Knight);
            var arus2 = new Arus("Arus", 45, HeroType.Knight);
          
            rpg.Arus.Add(new Arus("Arus", 45, HeroType.Knight));
            rpg.SaveChanges();

            rpg.Arus.Add(new Arus("The Wizard", 100, HeroType.Wizard));
            rpg.SaveChanges();
           
            System.Console.WriteLine(arus1);            
            System.Console.WriteLine(arus2);
            arus1.Attack();
            
            

            
           
                        
        }

       
    }
}
