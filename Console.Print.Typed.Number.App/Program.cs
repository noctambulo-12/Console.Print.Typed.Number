using System;

namespace Print.Typed.Number
{
    class Program
    {
        static void Main()
        {
            var cero = new string[11];
            var uno = new string[11];
            var cuatro = new string[11];
            var siete = new string[11];
            var ocho = new string[11];
            var imprimir = new string[11];

            
            cero[0] = "   # # #   ";
            cero[1] = " #       # ";
            cero[2] = " #       # ";
            cero[3] = " #       # ";
            cero[4] = " #       # ";
            cero[5] = " #       # ";
            cero[6] = "   # # #   ";

            uno[0] = "     #     ";
            uno[1] = "   # #     ";
            uno[2] = " #   #     ";
            uno[3] = "     #     ";
            uno[4] = "     #     ";
            uno[5] = "     #     ";
            uno[6] = " # # # # # ";

            cuatro[0] = " #       # ";
            cuatro[1] = " #       # ";
            cuatro[2] = " #       # ";
            cuatro[3] = " # # # # # ";
            cuatro[4] = "         # ";
            cuatro[5] = "         # ";
            cuatro[6] = "         # ";

            siete[0] = " # # # # # ";
            siete[1] = "         # ";
            siete[2] = "         # ";
            siete[3] = "         # ";
            siete[4] = "         # ";
            siete[5] = "         # ";
            siete[6] = "         # ";

            ocho[0] = " # # # # # ";
            ocho[1] = " #       # ";
            ocho[2] = " #       # ";
            ocho[3] = " # # # # # ";
            ocho[4] = " #       # ";
            ocho[5] = " #       # ";
            ocho[6] = " # # # # # ";

            Console.WriteLine("Ingrese un número: ");
            var numero = Console.ReadLine();
            Console.WriteLine(string.Empty);

            for (var columna = 0; columna < 11; columna++)
            {
                if (numero != null)
                    foreach (var digito in numero.ToCharArray())
                    {
                        imprimir[columna] = digito switch
                        {
                            '0' => imprimir[columna] + cero[columna],
                            '1' => imprimir[columna] + uno[columna],
                            '4' => imprimir[columna] + cuatro[columna],
                            '7' => imprimir[columna] + siete[columna],
                            '8' => imprimir[columna] + ocho[columna],
                            _ => imprimir[columna]
                        };
                    }

                Console.WriteLine(imprimir[columna]);
            }

            Console.ReadLine();
        }
    }
}
