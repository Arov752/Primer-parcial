using System;

namespace Primer_parcial
{
    using System;

    class Primer_parcial
    {
        static void Main(string[] args)
        {
            int Retiro, Transaccion, Numero;
            int V1 = 1000, V2 = 500, V3 = 200, V4 = 100;
            int c1, c2, c3, c4;
            int LimiteR = 20000, LimiteT = 10000;

            Console.Write("Bienvenido ");
            Console.WriteLine("Seleccione un banco");
            Console.WriteLine("1- FDP \n" +
                "2. Banreservas \n" +
                "3. Banco popular \n" +
                "4. exit");
            int B = Convert.ToInt32(Console.ReadLine());
            if (B == 1 || B == 2 || B == 3)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("Seleccione \n" +
                   "1. Transaccion \n" +
                   "2. Retiro \n" +
                   "3. Nada \n");

                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Introduzca la cantidad a depositar menor de {0}", LimiteT);
                    Transaccion = Convert.ToInt32(Console.ReadLine());

                    {
                        if (Transaccion <= 10000)
                        {
                            Console.WriteLine("Ingrese el numero de cuenta");
                            Numero = Convert.ToInt32(Console.ReadLine());
                            if (Numero > 999999999)
                            {
                                Console.WriteLine("Numero de cuenta invalido");

                            }
                            Console.WriteLine("Numero de cuenta verificado");
                            Console.WriteLine("Feliz dia");
                        }
                        else if (Transaccion > 10000)
                        {
                            Console.WriteLine("Limite excedido");
                        }
                    }

                }
                else if (opcion == 2)
                {

                  {
                        Console.WriteLine("Introduzca la cantidad a retirar menor de 20000", LimiteR);
                    Retiro = Convert.ToInt32(Console.ReadLine());
                   if (Retiro <= 20000)
                 {
                        {
                        c1 = Retiro / V1;
                        Retiro = Retiro - (V1 * c1);
                        Console.WriteLine("Se retiro La cantidad De {0} billetes de {1}", c1, V1);
                    }
                    if (Retiro >= 500)
                    {
                        c2 = Retiro / V2;
                        Retiro = Retiro - (V2 * c2);
                        Console.WriteLine("Se retiro la cantidad De {0} billetes de {1}", c2, V2);
                    }
                    if (Retiro >= 200) 
                    {
                        c3 = Retiro / V3;
                        Retiro = Retiro - (c3 * V3);
                        Console.WriteLine("Se retiro la cantidad de {0} billetes de {1}", c3, V3);
                    }
                    if (Retiro >= 100) 
                    {
                        c4 = Retiro / V4;
                        Retiro = Retiro - (c4 * V4);
                        Console.WriteLine("Se retiro la cantidad de {0} billetes de {1}", c4, V4);
                    }
                    Console.WriteLine("Retiro confirmado.");
                    Console.WriteLine("Gracias por usar nuestros servicios.");
                 }
                  else if (Retiro > 20000)
                        {
                            Console.WriteLine("Supera el limite de deposito");
                        }
                   }
                }



                else if (opcion == 3)
                {
                    Console.WriteLine("Gracias por preferirnos");
                }


            }
            if (B == 4)
                Console.WriteLine("Gracias, hasta la proxima");










        }
    }
}