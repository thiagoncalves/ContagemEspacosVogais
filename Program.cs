using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemEspacosVogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine().ToLower();

            int qtdeEspaco = QtdeEspaco(frase);
            int qtdeVogal = QtdeVogal(frase);

            Console.WriteLine("A quantidade de espaços é igual a: " + qtdeEspaco);
            Console.WriteLine("A quantidade de vogais é igual a: " + qtdeVogal);

            Console.ReadLine();
        }

    public static int QtdeVogal(string sentence)
        {
            int qtdeVogal = 0;

            char[] fraseInserida = sentence.ToCharArray();

            for (int i = 0; i < fraseInserida.Length; i++)
            {
                if (fraseInserida[i].ToString() == "a")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "e")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "i")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "o")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "u")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "é")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "ê")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "ã")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "á")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "â")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "à")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "õ")
                    qtdeVogal++;
                if (fraseInserida[i].ToString() == "ô")
                    qtdeVogal++;
            }
            return qtdeVogal;
        }

        public static int QtdeEspaco(string sentence)
        {
            int qtdeEspaco = 0;

            char[] fraseInserida1 = sentence.ToCharArray();

            for (int i = 0; i < fraseInserida1.Length; i++)
            {
                if (fraseInserida1[i].ToString() == " ")
                    qtdeEspaco++;
            }

            return qtdeEspaco;
        }
    }
}