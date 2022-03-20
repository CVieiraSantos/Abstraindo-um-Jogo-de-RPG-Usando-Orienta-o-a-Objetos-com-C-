using System;
using System.Text;

namespace Rpg
{
    public abstract class RpgAbstration
    {
        protected RpgAbstration(int id, string name, int level, HeroType heroType)
        {
            Id = id;
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        protected RpgAbstration(string name, int level, HeroType herotype)
        {            
            Name = name;
            Level = level;
            HeroType = herotype;
        }

        

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Level { get; private set; }
        public HeroType HeroType { get; private set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Id: ");
            sb.AppendLine(Id.ToString());
            sb.Append("Name: ");
            sb.AppendLine(Name);
            sb.Append("Level: ");
            sb.AppendLine(Level.ToString());
            sb.Append("HeroType: ");
            sb.AppendLine(HeroType.ToString());
            return sb.ToString();
        }

    }
}