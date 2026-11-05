using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    public class Produto
    {
        int Quantidade; // => Campo: é uma forma simplificada de representar atributos
        public string? Nome { get; set; }  //o get serve para retornar o valor da propriedade e o set para atribuir um valor a ela
        public decimal Preco { get; private set; }

        public void Exibir()
        {
            Console.WriteLine($"{Nome} - {Preco:C}");
        }
    }
}