using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Modelos.Exceptions
{
    public class PontosDeExperienciaInvalidosException : ArgumentException
    {
        public PontosDeExperienciaInvalidosException()
        {

        }
        public PontosDeExperienciaInvalidosException(string mensagem) : base(mensagem) 
        {

        }
        public PontosDeExperienciaInvalidosException(string mensagem, string paramName) : base(mensagem, paramName) 
        {

        }
    }
}
