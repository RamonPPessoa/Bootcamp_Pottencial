
using ExemploFundamentos.Common.Models;



List<string>listaString = new List<string>();
listaString.Add("AM");
listaString.Add("AC");
listaString.Add("SP");
listaString.Add("Manaus");

System.Console.WriteLine($"Itens da lista:{listaString.Count} - Capacidade{listaString.Capacity}");

listaString.Add("Ba");
System.Console.WriteLine($"Itens da lista:{listaString.Count} - Capacidade{listaString.Capacity}");

listaString.Remove("Ba");

System.Console.WriteLine($"Itens da lista:{listaString.Count} - Capacidade{listaString.Capacity}");

for (int i = 0; i <listaString.Count; i++)
{
    Console.WriteLine($"Posição{i} - {listaString[i]}");
}


foreach (var item in listaString)
{
    System.Console.WriteLine(item);
}












// int[] arrayInteiros = new int[3];
// arrayInteiros[0]= 100;
// arrayInteiros[1] = 200;
// arrayInteiros[2]=300;


// int[] arrayIntDobrado = new int[ arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros,arrayIntDobrado,arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros,arrayInteiros.Length *2);

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posicao Nº {contador} - {arrayInteiros[contador]}");
// }






// System.Console.WriteLine("Array usando foreach");
// int contadorForeach = 0;
// foreach (var item in collection)
// {
//     System.Console.WriteLine($"Posicao {contadorForeach} -  {item}");
//     contadorForeach++;
// }


// Pessoa p1 = new Pessoa();
// p1.Nome="Pessoa";
// p1.Idade=43;
// p1.Apresentar();

// int numero = 5;
// int contadorNovo =0;
 

// for (int contador = 0; contador <=10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero  * contador}"  );
// }


// System.Console.WriteLine("============================ While=========================");

// while (contadorNovo <=10)
// {
//     Console.WriteLine($"{contadorNovo} Execução: {numero} x {contadorNovo} = {numero  * contadorNovo}"  );
//     contadorNovo++;
// }
// Console.WriteLine("=============== DO WHILE =============");


// int soma=0, numeroNovo=0;
// do
// {
//     System.Console.WriteLine("Digite um numero(0 para sair)");
//     numeroNovo = Convert.ToInt32(Console.ReadLine());

//     soma +=numeroNovo;
// } while (numeroNovo!=0);
// System.Console.WriteLine($"A soma dos numeros digitados e:{soma}");


// Console.WriteLine("======================MENU==============================");

// string opcao;

// while (true)
// {
//     Console.Clear();
//     Console.WriteLine("Escolha uma opção");
//     Console.WriteLine("Cadastrar");
//     Console.WriteLine("Buscar");
//     Console.WriteLine("Apagar");
//     Console.WriteLine("Encerrar");

//     opcao = Console.ReadLine();
//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastrar");
//             break;

//         case "2":
//          Console.WriteLine("Buscar");
//             break;

//         case "3":
//              Console.WriteLine("Apager");
//             break;

//         case "4":
//              Console.WriteLine("Encerrar");
//              Environment.Exit(0);
//             break;

        
//         default:
//          Console.WriteLine("Opcao Inválida");
//             break;
//     }
// }




// Calculadora calc = new Calculadora();

// calc.Potencia(3,2);

// calc.Somar(5,5);

// bool chove = false;
// bool pelaTarde = false;

// if (!chove && !pelaTarde )
// {bool presenca = true;
// double media = 7.5;

// if (presenca && media >=7)
// {
//     Console.WriteLine("Vou caminhar");
// }

// else
// {
//     Console.WriteLine("Caminhar outro dia");
// }
    
// }

// bool presenca = true;
// double media = 7.5;

// if (presenca && media >=7)
// {
//     Console.WriteLine("Sucesso");
// }

// else
// {
//     Console.WriteLine("Ficou");
// }

// bool maiorIdade = false;
// bool autorizadoResponsavel = false;


// if (maiorIdade || autorizadoResposnvael)
// {
//     Console.WriteLine("Liberado");
// }
// else
// {
//     Console.WriteLine("Não liberado");
// }
// switch case

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "contador":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");

    
//     default:
//     Console.WriteLine("Não é vogal");
//     break;
// }







// Operador Condicional

// int qtdEstoque = 20;
// int qtdCompra = 15;
// bool venda = qtdCompra > 0  && qtdEstoque > = qtdCompra;

// Console.WriteLine($"Quantidade no estoque:  {qtdEstoque}");
// Console.WriteLine($"Quantidade de compra:  {qtdCompra}");
// Console.WriteLine($"Realizar venda? {venda}");

// if (qtdCompra ==0)
// {
    
// }

// else if (venda)
// {
//    Console.WriteLine("Venda efetuada"); 
// }
// else
// {
//     Console.WriteLine("Produto esgotado no estoque");
// }






// convertendo de maneira segura

// string a = "15-";

// int.TryParse(a,out int b);
// Console.WriteLine(b);
// Console.WriteLine("Sucesso");


// cast implicito
//  int a = int.MaxValue;
//  long b = a;

//  Console.WriteLine(b);


// int inteiro = 5;
// string a = inteiro.ToString();

// Casting convertesndo tipos de variáveis

//int a = Convert.ToInt32("10"); o convert aceita null

// int a = int.Parse("5"); // o Parse não aceita null
// Console.WriteLine(a);

// int a = 10;
// int b = 5;

// int c = a + b;

// c +=5;

// Console.WriteLine(  c);
// DateTime dataAtual = DateTime.Now;

// System.Console.WriteLine(dataAtual);

// DateTime dataAtua2 = DateTime.Now.AddDays(2);
// System.Console.WriteLine(dataAtua2);
// System.Console.WriteLine(dataAtua2.ToString("dd/MM/yyyy HH:mmgit commit "));

// string apresentacao = "Hello, welcome";

// int quantidade = 3;
//  double altura = 1.84;

//  decimal preco = 1.50M;
//  bool condicao = true;

//  Console.WriteLine( apresentacao);
//  Console.WriteLine("Quantidade:" + quantidade);
//  Console.WriteLine("Altura: " + altura.ToString("0.00"));
//  Console.WriteLine("Preço: " + preco);
//  Console.WriteLine("Condição: " + condicao);



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "João";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();