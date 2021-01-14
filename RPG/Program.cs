using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Modelos;
using RPG.Modelos.Raca;
using RPG.Modelos.Exceptions;

namespace RPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Heroi heroi1 = new Heroi("Farendor");
                heroi1.HeroiClasse("Clérigo");
                heroi1.PontosDeExperiencia = 4;


            }
            catch (PontosDeExperienciaInvalidosException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
