using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infija_Postfija
{
    class Program
    {
        static void Main(string[] args)
        {

            Infija_Postfija expresion = new Infija_Postfija();
            String[] aExpresion;
            aExpresion=expresion.expresionToArray("5+9*6-(3/2+4)*7+6");

            double resultado = expresion.calcularResultado(expresion.expresionPostfija(aExpresion));
            Console.WriteLine();
            Console.Write("resultado=" + resultado);
            Console.ReadKey();
        }
    }
}
