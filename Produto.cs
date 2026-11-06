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

        public void AlterarPreco(decimal novoPreco)
        {
            if (novoPreco > 0)
                Preco = novoPreco;
            else
                Console.WriteLine($"O {novoPreco} não é permitido, pois, é negativo!");
        }

        public Produto() // o metodo construtor sempre terá o mesmo nome da classe
        {
            Nome = "Não informado";
            Preco = 0;
        }

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Preco = valor;
        }
    }
}