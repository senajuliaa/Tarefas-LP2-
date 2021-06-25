using System;

namespace Tarefa_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // exibe menu principal
            string opcao = "";
            string r = "";
            string l1 = "";
            string l2 = "";

            while (opcao != "0")
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1 - Círculo");
                Console.WriteLine("2 - Retângulo");
                Console.WriteLine("3 - Trângulo-retângulo");
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("------------");
                Console.Write("Selecione uma figura: ");
                opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Obrigado por nos visitar. Volte sempre.");
                    Console.ReadLine();
                }
                else if (opcao == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("informe o valor do raio: ");
                    r = Console.ReadLine();

                    Circulo circ1 = new Circulo(Convert.ToInt32(r));
                    //circ1.Raio = 3.0;
                    Console.WriteLine("");
                    Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
                    Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
                    Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

                }
                else if (opcao == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine("informe o valor do lado menor: ");
                    l1 = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("informe o valor do lado maior: ");
                    l2 = Console.ReadLine();

                    Retangulo reta1 = new Retangulo(Convert.ToInt32(l1)+Convert.ToInt32(l2));
                    Console.WriteLine("");
                    Console.WriteLine("Soma dos lados:\t{0:0.0}", reta1.Lados);
                    Console.WriteLine("Área:\t\t{0:0.0}", reta1.Area);
                    Console.WriteLine("Perímetro\t{0:0.0}", reta1.Perimetro);
                }
                else if (opcao == "3")
                {
                }
                
                if (opcao != "0")
                {
                    Console.WriteLine("");
                    Console.WriteLine("<<< Digite enter para retornar >>>");
                    Console.ReadLine();
                }
            }
        }
    }
}