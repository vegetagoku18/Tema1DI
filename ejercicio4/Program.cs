using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio4
{
    internal class Program //TODO revisar menu
    {
        static void Juego1(int caras, int apuesta) // Hecho
        {
            int aciertos = 0;
            Random tirada = new Random();
            int comparador;
            string repetir;
            int repetirentero;

            Console.WriteLine("Generando tiradas");

            for (int i = 0; i < 10; i++)
            {
                comparador = tirada.Next(1, caras + 1);
                if (apuesta == comparador)
                {
                    aciertos++;
                }
                Console.WriteLine(comparador);
            }
            Console.WriteLine("Has acertado {0}", aciertos);
        }

        public static void Juego2() // Hecho
        {
            Random oculto = new Random();
            int ocultoentero = oculto.Next(1, 101);
            int intentos = 5;
            string respuesta;
            int respuestaentero;
            bool victoria = false;

            Console.WriteLine("En este juego debes acertar un número aleatorio entre el 1 y el 100");
            Console.WriteLine("Tienes 5 intentos en cada uno te diré si es mayor o menor que el número a acertar");
            Console.WriteLine("El numero oculto es: {0}", ocultoentero);
            while (intentos != 0 && !victoria)
            {
                Console.WriteLine("¿Qué número crees que es?");
                respuesta = Console.ReadLine();
                respuestaentero = Convert.ToInt32(respuesta);
                intentos--;
                while (respuestaentero <= 0 || respuestaentero > 100)
                {
                    Console.WriteLine("Ese valor no sirve, debe ser entre 1 y 100");
                    respuesta = Console.ReadLine();
                    respuestaentero = Convert.ToInt32(respuesta);
                }
                if (ocultoentero == respuestaentero)
                {
                    victoria = true;
                }
                else
                {
                    if (ocultoentero < respuestaentero)
                    {
                        Console.WriteLine("Tu número es mayor que el oculto");
                    }
                    else
                    {
                        if (ocultoentero > respuestaentero)
                        {
                            Console.WriteLine("Tu número es menor que el oculto");
                        }
                    }
                    Console.WriteLine("Te quedan {0} intentos", intentos);
                }
            }
            while (intentos != 0 && !victoria) ;

            if (victoria)
            {
                Console.WriteLine("Enhorabuena has ganado");
            }
            else
            {
                Console.WriteLine("Has perdido el número oculto era {0}", ocultoentero);
            }

        }

        public static void Juego3() // Hecho
        {
            Random resultado = new Random();
            string messi;
            Console.WriteLine("Generando quiniela");
            for (global::System.Int32 i = 1; i < 15; i++)
            {
                int resultadoentero = resultado.Next(1, 101);
                switch (resultadoentero)
                {
                    case int n when (n <= 60):
                        messi = "1";
                        break;
                    case int n when (n >= 85):
                        messi = "2";
                        break;
                    default:
                        messi = "X";
                        break;
                }
                Console.WriteLine("Partido {0,2}: {1,2}", i, messi);
            }
        }
        static void Main(string[] args)
        {
            string opciones;
            int opcionesentero;
            string repetir;
            int repetirentero = 1;
            bool opcion4 = false;
            do
            {
                Console.WriteLine("¿Qué juego quieres jugar?");
                Console.WriteLine("Juego 1: Acertar cuantas veces va a salir una cara de un dado");
                Console.WriteLine("Juego 2: Adivinar un número aleatorio");
                Console.WriteLine("Juego 3: Quiniela");
                Console.WriteLine("Juego 4: Todos los anteriores");
                Console.WriteLine("Juego 5: Ir tocar pasto (salir)");

                opciones = Console.ReadLine();
                opcionesentero = Convert.ToInt32(opciones);
                switch (opcionesentero)
                {
                    case 1:
                        string caras;
                        int carasentero;
                        string apuesta;
                        int apuestaentero;
                        while (repetirentero == 1)
                        {
                            Console.WriteLine("¿De cuántas caras quieres que sea el dado?");
                            caras = Console.ReadLine();
                            carasentero = Convert.ToInt32(caras);
                            while (carasentero <= 1)
                            {
                                Console.WriteLine("Un dado debe ser de mínimo 2 caras");
                                caras = Console.ReadLine();
                                carasentero = Convert.ToInt32(caras);
                            }
                            Console.WriteLine("¿Qué número quieres acertar?");
                            apuesta = Console.ReadLine();
                            apuestaentero = Convert.ToInt32(apuesta);
                            while (apuestaentero > carasentero || apuestaentero <= 0)
                            {
                                Console.WriteLine("Valor incorrecto");
                                apuesta = Console.ReadLine();
                                apuestaentero = Convert.ToInt32(apuesta);
                            }

                            Juego1(carasentero, apuestaentero);

                            Console.WriteLine("¿Quieres volver a jugar?");
                            Console.WriteLine("1: Si 2: No");
                            repetir = Console.ReadLine();
                            repetirentero = Convert.ToInt32(repetir);
                            while (repetirentero != 1 && repetirentero != 2)
                            {
                                Console.WriteLine("Valor no válido");
                                repetir = Console.ReadLine();
                                repetirentero = Convert.ToInt32(repetir);
                            }
                        }
                        if (opcion4)
                        {
                            repetirentero = 1;
                            goto case 2;
                        }
                        break;
                    case 2:
                        while (repetirentero == 1)
                        {
                            Juego2();
                            Console.WriteLine("¿Quieres volver a jugar?");
                            Console.WriteLine("1: Si 2: No");
                            repetir = Console.ReadLine();
                            repetirentero = Convert.ToInt32(repetir);
                            while (repetirentero != 1 && repetirentero != 2)
                            {
                                Console.WriteLine("Valor no válido");
                                repetir = Console.ReadLine();
                                repetirentero = Convert.ToInt32(repetir);
                            }
                        }
                        if (opcion4)
                        {
                            repetirentero = 1;
                            goto case 3;
                        }
                        break;
                    case 3: 
                        while (repetirentero == 1)
                        {
                            Juego3();
                            Console.WriteLine("¿Quieres volver a jugar?");
                            Console.WriteLine("1: Si 2: No");
                            repetir = Console.ReadLine();
                            repetirentero = Convert.ToInt32(repetir);
                            while (repetirentero != 1 && repetirentero != 2)
                            {
                                Console.WriteLine("Valor no válido");
                                repetir = Console.ReadLine();
                                repetirentero = Convert.ToInt32(repetir);
                            }
                        }

                        if (opcion4)
                        {
                            Console.WriteLine("¿Quieres volver a jugar a todos?");
                            Console.WriteLine("1: Si 2: No");
                            repetir = Console.ReadLine();
                            repetirentero = Convert.ToInt32(repetir);
                            while (repetirentero != 1 && repetirentero != 2)
                            {
                                Console.WriteLine("Valor no válido");
                                repetir = Console.ReadLine();
                                repetirentero = Convert.ToInt32(repetir);
                            }
                            if (repetirentero == 1)
                            {
                                goto case 1;
                            }
                        }
                        break;
                    case 4:
                        opcion4 = true;
                        goto case 1;
                    case 5:
                        Console.WriteLine("Muchas gracias por usar este servicio");
                        break;
                    default:
                        Console.WriteLine("Valor incorrecto");
                        break;
                }
            }
            while (opcionesentero != 5);
        }
    }
}
