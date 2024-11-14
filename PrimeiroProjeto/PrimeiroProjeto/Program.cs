using System.Globalization;

namespace PrimeiroProjeto {

    public class Program : CalculoSimples {

        private static void Main(string[] args) {
            Program executar = new Program();

            executar.ExecultarAulaDois();
        }

        public void Execultar() {
            double x = 10.2345;
            int y = 32;
            string z = "maria";
            char w = 'F';

            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom Dia");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F4", CultureInfo.InvariantCulture));//aqui ele tira o , e coloca .

            Console.WriteLine();
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seus sexo é: " + w);

            // Calculo calculo = new Calculo();
            //Console.WriteLine("Valor do calculo é: " + calculo.areaCacucula());
            Console.WriteLine();

            CalculoSimples simples = new CalculoSimples();
            //Console.WriteLine("Valor do resultado simples é: " + simples.calculoSimplesNew());

            //DigitandoSalvoVariavel digitar = new DigitandoSalvoVariavel();
            //Console.WriteLine("Digitado foi: " + digitar.Salvo());
            Console.WriteLine("Aula 4 - Digite apenas Números");

            Console.WriteLine("Valor digitado foi: " + simples.aulaQuatro());
            Console.WriteLine("Letra digitada foi: " + simples.texto());
            Console.WriteLine("Número digitado foi: " + simples.numero().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Aula Tres");
            simples.aulaTres();

            Console.ReadLine();
        }

        public void ExecultarAulaDois() {
            double largura, compimento, precoMetroQuatrado, area, preco;

            while (true) {
                Console.WriteLine("Digite o valor da largura:");
                string input = Console.ReadLine();
                bool Numeric = double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out largura);

                if (Numeric) {
                    break;
                } else {
                    Console.WriteLine("Valor inválido! Por favor insira um número.");
                }
            }
            while (true) {
                Console.WriteLine("Digite o valor do comprimento");
                string input = Console.ReadLine();
                bool Numeric = double.TryParse(input, NumberStyles.Float,CultureInfo.InvariantCulture, out compimento);
                if (Numeric) {
                    break;
                } else {
                    Console.WriteLine("Valor inválido! Por favor insira um número.");


                }
            }
            while (true) {
                Console.WriteLine("Digite o valor do metro quatrado");
                string input = Console.ReadLine();
                bool Numeric = double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out precoMetroQuatrado);
                if (Numeric) {
                    break;
                } else {
                    Console.WriteLine("Valor inválido! Por favor insira um número.");

                }
            }
            area = largura * compimento;
            preco = area * precoMetroQuatrado;

            Console.WriteLine("Area do metro quatrado: " + area.ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "Preço em metros quadrados: " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}