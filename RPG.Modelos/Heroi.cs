using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Modelos
{
    public class Heroi
    {
        public Heroi(string nomeHeroi)
        {
            HeroiNome = nomeHeroi;
        }
        public string HeroiNome { get; private set; }
        public string HeroiRaca { get; private set; }
        public string HeroiClasse { get; private set; }
    
    }
}
