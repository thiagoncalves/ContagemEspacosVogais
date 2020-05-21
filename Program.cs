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

            int qtdeVogal = 0;
            int qtdeEspaco = 0;
            char[] fraseInserida = frase.ToCharArray();

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
                if (fraseInserida[i].ToString() == " ")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "é")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "ê")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "ã")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "á")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "â")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "à")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "õ")
                    qtdeEspaco++;
                if (fraseInserida[i].ToString() == "ô")
                    qtdeEspaco++;
            }

            Console.WriteLine("A quantidade de espaços é igual a: " + qtdeEspaco);
            Console.WriteLine("A quantidade de vogais é igual a: " + qtdeVogal);
            
            Console.ReadLine();
        }

    }
}