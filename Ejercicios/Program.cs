using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\t\tGRUPO *********");
            Console.WriteLine("\t\t===============");
            Console.WriteLine("[1] SOL");
            Console.WriteLine("[2] FRANK");
            Console.WriteLine("[3] WILLIAN");
            Console.WriteLine("[4] CARLOS");
            Console.WriteLine("[5] CARLOS");
            Console.WriteLine("[6] FRANK");
            Console.WriteLine("[7] RICHARD");
            Console.WriteLine("[8] JUEGO MICHI");
            Console.WriteLine("[0] SALIR");
            Console.Write("\nSeleccione opción: ");
            String opc = Console.ReadLine();

            switch (opc)
            {
                case "0":
                    Console.WriteLine("Hasta Luego... presione cualqiuer tecla para terminar");
                    Console.ReadKey();
                    break;
                case "1":
                    Ejercicio1();
                    Main(null);
                    break;
                case "2":
                    Ejercicio2();
                    Main(null);
                    break;
                case "3":
                    Ejercicio3();
                    Main(null);
                    break;
                case "4":
                    Ejercicio4();
                    Main(null);
                    break;
                case "5":
                    Ejercicio5();
                    Main(null);
                    break;
                case "6":
                    Ejercicio6();
                    Main(null);
                    break;
                case "7":
                    Ejercicio7();
                    Main(null);
                    break;
                case "8":
                    Ejercicio8();
                    Main(null);
                    break;
                default:
                    Main(null);
                    break;
            }

           
        }
        static void Ejercicio1()
        {
            /*
             1.- Escriba un programa que pida dos números enteros. El programa pedirá de nuevo el segundo número
                 mientras no sea mayor que el primero. El programa terminará escribiendo los dos números.
             */
            Console.Clear();
            int numero1;
            int numero2;

            Console.Write("Escriba un numero: ");

            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Escriba un numero mayor que {0}: ", numero1);
            numero2 = int.Parse(Console.ReadLine());
            do
            {

                Console.Write("{0} no es mayor que {1}.Intentelo de nuevo: ", numero1, numero2);
                numero2 = int.Parse(Console.ReadLine());
            }
            while (numero2 < numero1);

            Console.WriteLine();
            Console.WriteLine("Los numeros que has escrito son {0} y {1}.", numero1, numero2);
            Console.WriteLine("Programa terminado");
            Console.ReadKey();

        }

        static void Ejercicio2()
        {
            /*
             2.- Escriba un programa que pida números decimales mientras el usuario escriba número mayores que el
                 primero.
             */
            Console.Clear();
            float numerobase = 0;
            float numero = 0;
            Console.Write("Escriba un número: ");
            numerobase = float.Parse(Console.ReadLine());
            Console.Write("Escriba un número mayor que {0}: ",numerobase);
            numero = float.Parse(Console.ReadLine());
            if (numero > numerobase)
            {
                do
                {
                    Console.Write("Escriba un número mayor que {0}: ", numerobase);
                    numero = float.Parse(Console.ReadLine());
                } while (numero > numerobase);
            }
            Console.WriteLine("{0:N1} no es mayor que {1:N1}. ",numero , numerobase);
            Console.WriteLine("Programa Terminado");
            Console.ReadKey();

        }
        static void Ejercicio3()
        {
            /*
             3.- Escriba un programa que pida números enteros mientras sean cada vez más grandes.
             */
            Console.Clear();
            Console.Write("Escriba un número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Escriba un número mayor que {0}: ", numero);
            int mayor = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Escriba un número mayor que {0}: ", mayor);
                numero = mayor;
                mayor = int.Parse(Console.ReadLine());

            } while (mayor > numero);
            Console.WriteLine(mayor + " no es mayor que " + numero + ".");
            Console.WriteLine("Programa terminado");

            Console.ReadKey();
        }
        static void Ejercicio4()
        {

            /*
             4.- Escriba un programa que pida la cantidad de números positivos que se tienen que escribir y a continuación
                 pida números hasta que se haya escrito la cantidad de números positivos indicada.
             */
            Console.Clear();
            int cant, conta = 0, num, contb = 0, aa = 0, validar = 0;

            do
            {
                Console.Write("Escriba la cantidad de numeros positivos a escribir: ");
                cant = int.Parse(Console.ReadLine());
                if (cant > 0)
                {
                    do
                    {
                        Console.Write("Escriba un numero: ");
                        num = int.Parse(Console.ReadLine());
                        if (num < 0)
                        {
                            contb++;
                        }
                        else
                        {
                            conta++;
                        }
                    } while (conta < cant);
                    aa = contb + cant;
                    Console.WriteLine("Ha escrito {0} numeros, {1} de ellos positivos.", aa, cant);
                    break;
                }
                else
                {
                    Console.WriteLine("Ingresar cantidad mayor a 0");
                    validar = 1;
                }
            } while (validar != 0);
            Console.WriteLine("Programa Terminado");
            Console.ReadKey();

        }
        static void Ejercicio5()
        {
            /*
             5.- Escriba un programa que pida números mientras no se escriba un número negativo. El programa terminará
                 escribiendo la suma de los números introducidos.
             */
            Console.Clear();
            int n, sum = 0;
            Console.Write("Escriba un numero: ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("La suma de los numeros positivos ingresados es : 0");
                Console.WriteLine("Programa terminado.");
            }
            else
            {
                sum = sum + n;
                do
                {
                    Console.Write("Escriba otro numero: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("La suma de los numeros positivos ingresados es : {0}", sum);
                        Console.WriteLine("Programa terminado.");
                        break;
                    }
                    else
                    {
                        sum = sum + n;
                    }
                }
                while (n >= 0);
            }
            Console.ReadKey();
        }

        static void Ejercicio6()
        {
            /*
            6.- Escriba un programa que pida un valor límite positivo y a continuación pida números hasta que la suma de
           los números introducidos supere el límite inicial.
            */
            Console.Clear();
            float limit = 0;
            float suma = 0;
            float numero = 0;
            Console.Write("Escriba el valor límite: ");
            limit = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Escriba un número: ");
            do
            {
                numero = float.Parse(Console.ReadLine());
                suma = suma + numero;
                if (suma > limit)
                {
                    break;
                }
                Console.Write("Escriba otro número: ");
            } while (suma < limit);
            Console.WriteLine("Ha superado el limite. La suma de los números introducidos es {0}", suma);
            Console.WriteLine("Programa Terminado");
            Console.ReadKey();
        }
        static void Ejercicio7()
        {
            /* 7.- Escriba un programa que pida primero dos números enteros (mínimo y máximo) y que después pida números
                   enteros situados entre ellos. El programa terminará cuando se escriba un número que no esté comprendido
                   entre los dos valores iniciales.El programa termina escribiendo la cantidad de números escritos.*/
            Console.Clear();
            int numMin, numMax, cont = 0, numero;
            bool isRango = true;

            Console.Write("Escribe un número: ");
            numMin = int.Parse(Console.ReadLine());

            Console.Write("Escribe un número mayor que {0}: ", numMin);
            numMax = int.Parse(Console.ReadLine());

            while (numMin >= numMax)
            {
                Console.Write("El {0} no es mayor que {1}. Inténtelo de nuevo: ", numMax, numMin);
                numMax = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            do
            {
                //isRango = false;
                if (cont < 1)
                {
                    Console.Write("Escriba un número entre {0} y {1}: ", numMin, numMax);
                    numero = int.Parse(Console.ReadLine());
                    cont++;

                }
                else
                {
                    Console.Write("Escriba otro número entre {0} y {1}: ", numMin, numMax);
                    numero = int.Parse(Console.ReadLine());
                    cont++;
                }

                if (numero < numMin || numero > numMax)
                {
                    isRango = false;
                }
                else
                {
                    isRango = true;
                }
            } while (isRango);

            Console.WriteLine();
            Console.WriteLine("Ha escrito {0} números entre {1} y {2}", cont - 1, numMin, numMax);
            Console.Write("Programa Terminado");
            Console.ReadKey();
        }
        static void Ejercicio8()
        {
            //Console.Write("En progreso...");
            //Console.ReadKey();
            Console.Clear();
            int posicionX, posicionY;
            Boolean ganador = false, bandera = true;

            int jugador = 1;
            char[ , ] michi = new char[4, 4] { { '1','2', '3', '4' },{ '2','-', '-', '-' }, { '3','-', '-', '-' }, { '4','-', '-', '-' } };

            imprimir(michi);

            do
            {
                if (jugador == 1)
                {
                    Console.WriteLine("JUGADOR 1 == X");
                    do
                    {
                        Console.Write("Ingrese la posicion eje(Y): ");
                        posicionX = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la posicion eje(X): ");
                        posicionY = int.Parse(Console.ReadLine());
                        if (michi[posicionX - 1, posicionY - 1] == '-')
                        {
                            michi[posicionX - 1, posicionY - 1] = 'X';
                            ganador = validar(michi);
                            jugador =2;
                            bandera = false;
                        }else
                        {
                            Console.WriteLine("JUGADOR 1 == X (ELIGE OTRA POSICIÓN)");
                            jugador = 1;
                            bandera = true;
                        }
                        

                    } while (bandera);
                    imprimir(michi);
                }          
               if(jugador == 2)
                {
                    
                    Console.WriteLine("JUGADOR 2 == 0");
                    do
                    {
                        if (ganador)
                        {
                            break;
                        }
                        Console.Write("Ingrese la posicion eje(Y): ");
                        posicionX = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la posicion eje(X): ");
                        posicionY = int.Parse(Console.ReadLine());
                        if (michi[posicionX - 1, posicionY - 1] == '-')
                        {
                            michi[posicionX - 1, posicionY - 1] = '0';
                            ganador = validar(michi);
                            jugador = 1;
                            bandera = false;
                        }
                        else
                        {
                            Console.WriteLine("JUGADOR 2 == 0 (ELIGE OTRA POSICIÓN)");
                            jugador = 2;
                            bandera = true;
                        }
                    } while (bandera);
                    imprimir(michi);
                }
                
            } while (!ganador);
            

           
            Console.ReadKey();
        }
        static void imprimir(char[,] michi)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(michi[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static Boolean validar(char[ , ] michi)
        {
            Boolean ganador = false;
            int i = 1;
            int j = 1;
            do
            {
                    if (michi[i, j] == michi[i, j + 1] && michi[i, j] == michi[i, j + 2])
                    {
                        ganador = true;
                        return ganador;

                    }
                    else
                    {
                        ganador = false;
                        return ganador;
                    }
                
                    i++;
            } while (i<4);
            return ganador;
        }
    }
}
