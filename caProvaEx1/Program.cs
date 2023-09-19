using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            
            int i = 0;
            while (i != 5)
            {
                Console.WriteLine("\r\nO que o senhor(a) Deseja fazer?" +
                   "\r\n 1 - Insira um inteiro na lista" +
                   "\r\n 2 - Remova um inteiro da lista" +
                   "\r\n 3 - Imprima o maior elemento da lista" +
                   "\r\n 4 - Imprima a lista" +
                   "\r\n 5 - SAIR\r\n");
                i = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    Console.WriteLine("Digite o numero a ser inserido");
                    int n = Convert.ToInt32(Console.ReadLine());
                    l.Insere(n);
                    Console.ReadLine();

                }
                if (i == 2)
                {
                    Console.WriteLine("Digite o número a ser removido");
                    int n = Convert.ToInt32(Console.ReadLine());
                    l.Remove(n);
                    Console.ReadLine();
                }
                if (i == 3)
                {
                    Console.WriteLine("O maior da Lista é:" + l.Maior());
                    Console.ReadLine();
                    

                }
                if (i == 4)
                {
                    l.Imprime();
                    Console.ReadLine();
                }
            }  




        }//fim main
    }
}
