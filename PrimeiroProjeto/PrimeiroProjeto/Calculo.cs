using System.Formats.Asn1;

namespace PrimeiroProjeto {

    public class Calculo {

        public double areaCacucula() {//Aqui é um metódo 
            Console.Write("Digite o valor de b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de B:");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de h:");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = (b + B) / 2.0 * h;

            return area;
        }
    }
}