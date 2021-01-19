using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Modelos.Exceptions;

namespace RPG.Modelos
{
    public class Heroi
    {
        private int _heroiLevel = 1;
        public int HeroiLevel { get { return _heroiLevel; } set {} }
        public Heroi(string nomeHeroi)
        {
            HeroiNome = nomeHeroi;
        }
        public string HeroiNome { get;  private set; }
        public void HeroiClasse (string heroiClasse) 
        {
        }
        public void HeroiRaca(string heroiRaca)
        {
        }
        public void HeroiAntencendente(string heroiAntencendente)
        {
        }
        public void HeroiTendencia(string heroiTendencia)
        {

        }
        public int _pontosDeExperiencia;
        public void AdicionarPontosDeExperiencia(int pontosXP) 
        {   
            if (pontosXP <= 0) 
            {
                throw new PontosDeExperienciaInvalidosException("Os pontos de experiencia devem ser maior que 0", nameof(pontosXP));
            }
            while (pontosXP>=100)
            {
                _pontosDeExperiencia += 100;
                _heroiLevel++;
                Console.WriteLine(HeroiNome + " subiu para o nivel " + HeroiLevel);
                pontosXP -= 100;
            }
            Console.WriteLine("Total de XP obtidos: " + _pontosDeExperiencia);
            Console.WriteLine("Héroi: "+HeroiNome+" Level: "+HeroiLevel);
        }
    }
}
