using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos pts = new Produtos();
  //          Produto pt = new Produto();
      
            int op = 0;
            int cod;
            string desc;
            int qtd;
            double preco;

            do
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("|            MENU              |");
                Console.WriteLine("| ============================ |");
                Console.WriteLine("| 0 - Sair                     |");
                Console.WriteLine("| 1 - Adicionar Produto        |");
                Console.WriteLine("| 2 - Pesquisar Produto        |");
                Console.WriteLine("| 3 - Excluir Produto          |");
                Console.WriteLine("| 4 - Listar Produtos          |");
                Console.WriteLine("================================");
                Console.Write("Escolha uma opcao:   ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 0:
                            Console.WriteLine("Programa Finalizado !!!!!");
                            break;
                    case 1:
                        Console.WriteLine("\n Adicionar Produto . . .  ");
                        Console.Write("Insira o Codigo do Produto:  ");
                        cod = int.Parse(Console.ReadLine());
                        // pesquisar se ja existi algum produto com o mesmo cod/
                        // if sim -> nao continua,  else continua
                        bool resultPesqAdc = pts.PesquisarAdc(new Produto(cod, "", 0, 0));
                        if (!resultPesqAdc){ Console.WriteLine("Codigo do protudo ja utilizado !!!"); break;}
                        Console.Write("Insira a descrição do Produto:  ");
                        desc = Console.ReadLine();
                        Console.Write("Insira a Quantidade:  ");
                        qtd = int.Parse(Console.ReadLine());
                        Console.Write("Insira o Valor: R$ ");
                        preco = double.Parse(Console.ReadLine());
                        pts.Adicionar(new Produto(cod, desc, qtd, preco));
                        break;

                    case 2: // pesquisar
                        Console.WriteLine("\nPesquisanto produto . . .  ");
                        Console.WriteLine("Digite o Codigo: ");
                        cod = int.Parse(Console.ReadLine());
                        Produto result = pts.Pesquisar(new Produto(cod, "", 0, 0));
                        Console.WriteLine("Codigo : " + result.cod + "\nDescrição : " + result.desc + "\nQtde : " + result.qtd + "\nPreco : " + result.preco);
                        break;

                    case 3: // remover
                        Console.WriteLine("\nRemovendo Produto . . .");
                        Console.Write("Digite o Codigo: ");
                        cod = int.Parse(Console.ReadLine());
                        Console.Write("Tem certeza S ou N? ");
                        string x = Console.ReadLine().ToUpper();

                        if (x == "S")
                        {
                            bool resultado = pts.Remover(new Produto(cod, "", 0, 0));
                            if (resultado){ Console.WriteLine("Apagado com sucesso"); }
                            else { Console.WriteLine("Não foi possivel apagar");}
                        }

                        break;

                    case 4:// listar produtos
                        foreach (Produto elemento in pts.ListaProdutos){
                            Produto resultado = pts.Pesquisar(new Produto(elemento.cod, "", 0, 0));
                            Console.WriteLine("\nCodigo : " + resultado.cod + "\nDescrição : " + resultado.desc + "\nQtde : " + resultado.qtd + "\nPreco : " + resultado.preco + "\n");
                        }
                        Console.WriteLine("Custo total: R$ "+ pts.custoTotal());
                        break;

                }// fim swith case
            } while (op != 0);

            Console.ReadKey();
        }
    }
}
