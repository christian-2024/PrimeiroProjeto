using System.Globalization;

namespace PrimeiroProjeto {

    public class CalculoSimples {

        public double calculoSimplesNew() {
            int a, b;
            double resultado;
            Console.Write("Digite o valor para ser dividido por 2: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = 2;
            resultado = (double)a / b;

            return resultado;
        }

        public int aulaQuatro() {
            while (true) {
                try {
                    int valor = int.Parse(Console.ReadLine());
                    return valor;
                } catch (Exception e) {
                    // Console.WriteLine(e.Message);
                    Console.WriteLine("Erro! Digite apenas números.");
                  //  return aulaQuatro();
                }
            }
        }
        public char texto() {
            while (true) {
                try {
                    char caractere = char.Parse(Console.ReadLine());
                    return caractere;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public double numero() {
            while (true) {
                try {
                    double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                   
                    return n2;
                } catch (Exception e) {
                    Console.WriteLine("verifique o que digitou");
                }
            }
        }

        public void aulaTres() {

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            string sexo = vet[1];
            byte idade = byte.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}