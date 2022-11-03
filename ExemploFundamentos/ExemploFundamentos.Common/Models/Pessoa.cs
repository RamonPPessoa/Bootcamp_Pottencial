using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
         public int Idade { get; set; }
        public string Nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Hi my name is{Nome} and i have {Idade} anos");
        }
    }
}