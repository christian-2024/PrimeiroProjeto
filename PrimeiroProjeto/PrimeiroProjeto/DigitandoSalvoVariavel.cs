﻿namespace PrimeiroProjeto {
    public class DigitandoSalvoVariavel {

        public string Salvo() {

            string frase = Console.ReadLine(); 
            string x = Console.ReadLine();
            string y = Console.ReadLine();  
            string z = Console.ReadLine();
            Console.WriteLine("Digite trêz palabras?");
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


            return frase + x + y + z;
        
        }
    }
}