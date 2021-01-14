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
        public int HeroiLevel = 1;
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
        private int _PontosDeExperiencia = 0;
        public int PontosDeExperiencia 
        { 
            get 
            {
                return _PontosDeExperiencia;
            } 
            set 
            {
                if (value < 0)
                {
                    throw new PontosDeExperienciaInvalidosException("Pontos de experiencia invalidos!", nameof(value));
                }
                else 
                {
                    _PontosDeExperiencia = PontosDeExperiencia;
                }
            } 
        }
    }
}
