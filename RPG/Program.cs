using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Modelos;
namespace RPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Heroi heroi1 = new Heroi("Farendor");
            Console.WriteLine(heroi1.HeroiNome);
            Console.WriteLine(heroi1.HeroiClasse);
            Console.WriteLine(heroi1.HeroiRaca);

            Console.ReadLine();
        }
    }
}
