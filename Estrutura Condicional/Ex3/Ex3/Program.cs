using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            if(n1 % n2 ==0 || n2 % n1 == 0){
                Console.WriteLine("Sao multimos");
            } 
            else{
                Console.WriteLine("nao sao multiplos");
            }
        }
    }
}
