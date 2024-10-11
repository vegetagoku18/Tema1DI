#define FRASE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string frase1;
            string frase2;
            Console.WriteLine("Dime una frase");
            frase1 = Console.ReadLine();
            Console.WriteLine("Dime una frase");
            frase2 = Console.ReadLine();
#if FRASE
            //Console.WriteLine(frase1 +"\t"+ frase2+"\n"+frase1+"\n"+frase2);//TODO sin concatenar
            Console.WriteLine("{0} \t {1} \n {0} \n {1}",frase1,frase2);
            //Console.WriteLine("\"frase1\""+"\\frase2\\");
#else
            Console.WriteLine("\"{0}\" \"{1}\"",frase1,frase2);
#endif
        }
    }
}
