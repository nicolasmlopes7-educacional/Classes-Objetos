// string nome = "Nicolas";

using ClassesObjetos;

Produto p1 = new Produto(); // instanciando um objeto da classe Produto
p1.Nome = "Notebook";
// p1.Preco = 3500m;

p1.AlterarPreco(3500m);
p1.Exibir();

Produto p2 = new Produto();
p2.Nome = "Mouse";
// p2.Preco = 200m;
p2.AlterarPreco(200m);

p2.Exibir();

Produto p3 = new Produto("Fone", 250m);
p3.Exibir();
// Conta.Depositar(1000);
// Conta.Depositar(100);

// Conta conta_corrente = new Conta();
// Conta conta_poupanca = new Conta();

// conta_corrente.Depositar(100);
// conta_poupanca.Depositar(50);

// Console.WriteLine(Math.Round(10.6700, 2));

