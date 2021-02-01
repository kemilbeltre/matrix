using System;
//Este programa crea una matriz con los parametros que ingrese el usurio y permite modificar cada uno de ellos.
//Por Kemil Beltre.
namespace matrizsolucion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hago el llamado al metodo que tiene las opciones principales del programa.
            menumatriz();
            Console.ReadKey(true);
        }

        private static void indicematriz(out int tamfilas, out int tamcol, out int [,] matrizus)
        {
            //por esta parte el programa pide las dimenciones de la matriz.
            Console.WriteLine("¿Cuantas filas tendra la matriz?");
            tamfilas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Cuantas columnas tendra la matriz?");
            tamcol = Convert.ToInt32(Console.ReadLine());
            
             matrizus = new int[tamfilas,tamcol];
            //creo un ciclo for por el cual permitira al usuario rellenar la matriz.
            for (int indicefilas = 0; indicefilas < tamfilas; indicefilas++)
            {
                for (int indiceCol = 0; indiceCol < tamcol; indiceCol++)
                {
                    Console.WriteLine("Ingrese el dato del índice [" + indicefilas + "," + indiceCol + "]:");
                    matrizus[indicefilas, indiceCol] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

        private static void menumatriz() //este metodo permitira modificar cada parte de la matriz ingresada por el usurio. 
        {
            int filaUsuario, colUsuario, elemento, reemplazo, contador, opcion;
            bool encontrado;
            indicematriz(out int tamfilas, out int tamcol, out int[,] matrizus);

            do
            {
                Console.WriteLine("1. Modificar un elemento por sus indices");
                Console.WriteLine("2. Modificar un elemento por sus coincidencias");
                Console.WriteLine("3. Mostrar los datos de la matriz");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Elige una opción");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear(); //limpiará la pantalla luego de elegir una opcón del menú.

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el índice de la fila: ");
                        filaUsuario = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingresa el índice de la columna: ");
                        colUsuario = Convert.ToInt32(Console.ReadLine());

                        if (filaUsuario < tamfilas && colUsuario < tamcol)
                        {
                            Console.WriteLine("Ingresa el nuevo elemento del índice [" + filaUsuario + "," + colUsuario + "]: ");
                            matrizus[filaUsuario, colUsuario] = Convert.ToInt32(Console.ReadLine()); //guardamos datos ingresados en la matriz.
                        }
                        else
                        {
                            Console.WriteLine("El índice [" + filaUsuario + "," + colUsuario + "] no existe.");
                        }

                        break;

                    case 2:
                        contador = 0;
                        encontrado = false; //al principio el contador inicia en falso ya que no se han pedido ninguna  modificacion.
                        Console.WriteLine("Ingresar el número a reemplazar: ");
                        elemento = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingresar el número de reemplazo: ");
                        reemplazo = Convert.ToInt32(Console.ReadLine());

                        for (int indicefilas = 0; indicefilas < tamfilas; indicefilas++)
                        {
                            for (int indiceCol = 0; indiceCol < tamcol; indiceCol++)
                            {
                                if (matrizus[indicefilas, indiceCol] == elemento)
                                {
                                    encontrado = true;
                                    contador++;
                                    matrizus[indicefilas, indiceCol] = reemplazo;
                                }

                            }
                            if (encontrado == true)
                            {
                                Console.WriteLine("Se encontraron " + contador + " coincidencias " + elemento + " y fueron reemplazados por " + reemplazo);
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron coincidencias con " + elemento);
                            }
                        }
                        break;

                        //creamos un ciclo for para mostrar los datos de la matriz.
                    case 3:
                        for (int indicefilas = 0; indicefilas < tamfilas; indicefilas++)
                        {
                            for (int indiceCol = 0; indiceCol < tamcol; indiceCol++)
                            {
                                Console.Write(" " + matrizus[indicefilas, indiceCol]);
                            }
                            Console.WriteLine();
                        }

                        break;
                    case 4:
                        Console.WriteLine("Aplicación finalizada");
                        break;
                    default:
                        Console.WriteLine("OPCIÓN INCORRECTA"); //cuando se ingrese un número diferente al del menú de opciones, saltará este mensaje.
                        break;

                }
            } while (opcion != 4);

        }



    }
}
