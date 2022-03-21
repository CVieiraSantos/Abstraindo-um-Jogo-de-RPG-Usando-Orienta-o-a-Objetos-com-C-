namespace Rpg.Domain.Models
{
    public class Arus : RpgAbstration, IAttack
    {
        public Arus(int id, string name, int level, HeroType heroType) : base(id, name, level, heroType)
        {            
        }

        public Arus(string name, int level, HeroType heroType) : base(name, level, heroType)
        {    
            
        }

        public void Attack()
        {
            System.Console.WriteLine("Atacar com socos e chutes");
        }
    }
}