using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionarios Funcionario1 = new Funcionarios();
            Funcionarios Funcionario2 = new Funcionarios();

            double salariomedio;

            Console.WriteLine("Digite o nome do fguncionario1 ");
            Funcionario1.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario: ");
            Funcionario1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do funcionario2 ");
            Funcionario2.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario: ");
            Funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salariomedio = (Funcionario1.salario + Funcionario2.salario) / 2;

            Console.WriteLine("Salario medio = " + salariomedio.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
