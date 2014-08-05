using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using playground.Model;

namespace PlaygroundSemCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Conteudo conteudo = new Conteudo();

            Console.WriteLine("Começou sem cache");

            for (int i = 1; i <= 1500; i++)
            {
                Console.WriteLine(conteudo.getConteudo(new System.Random().Next(50)).nome);    
            }

            Console.WriteLine("Acabou");
            Console.Beep();
            Console.WriteLine(DateTime.Now.ToString());
            Console.ReadLine();
            

        }
    }
}
