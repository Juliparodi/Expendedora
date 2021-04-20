using ExpendedoraLibrary.Entities;
using System;
using System.Collections.Generic;
using ExpendedoraLibrary.Validaciones;
using ExpendedoraLibrary.Exceptions;


namespace ExpendedoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            bool esValido = true;
            bool salir = false;

            Expendedora expendedora = new Expendedora();
            List<Lata> latas = new List<Lata>();
            Lata lata = new Lata("01", "coca-cola", "coca", 10, 100, 100);
            Lata lata2 = new Lata("02", "sprite", "limon", 10, 100, 100);
            latas.Add(lata);
            latas.Add(lata2);
            expendedora.encenderMaquina();
            expendedora.agregarLatas(latas);

            int numero = Validaciones.validarInt();
            double numero2 = Validaciones.validarDouble();
            long numero3 = Validaciones.validarLong();

            Console.WriteLine("numero 1: {0}, numero 2: {1} , numero 3: {2}", numero, numero2, numero3);

            Console.Write("Bienvenido a la maquina expendedora mas premium de Argentina");

            do
            {
                Console.Write("\n por favor seleccione una opcion" +
                    "\n 0 - encender la maquina" +
                    "\n 1- listado de latas disponibles" +
                    "\n  2 - insertar lata" +
                    "\n  3 - extraer lata" +
                    "\n  4 - conocer mi balance" +
                    "\n  5 - conocer stock disponible" +
                     "\n  6 -  salir");

                do
                {
                    try
                    {
                        Console.WriteLine("Por favor seleccione la opcion");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        esValido = true;

                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ocurrio un error al seleccionar la opcion, x favor intente devuelta");
                    }
                } while (!esValido);

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Encender maquina");
                            expendedora.encenderMaquina();
                            break;

                        case 1:
                            Console.WriteLine("Latas disponibles");
                            expendedora.listarLatas();
                            break;

                        case 2:
                        try {
                            expendedora.agregarLata(recolectarParametros());
                            } catch (MaquinaApagadaException ex)
                        {
                            Console.WriteLine(ex);
                        }
                            break;



                    } 

            } while (salir);

        }

        public static Lata ingresarLata(Expendedora expendedora)
        {
            Lata lata2 = new Lata();
            Console.Write("Agregar lata" +
                 "\n  por favor ingrese codigo, nombre, precio" +
                 "\n volumen y stock");
            Console.WriteLine("Ingrese codigo: ");
            lata2.Codigo = Console.ReadLine();
            Console.WriteLine("Ingrese nombre: ");
            lata2.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese nombre: ");
            lata2.Cantidad = Validaciones.validarInt();
            Console.WriteLine("Ingrese nombre: ");
            lata2.Precio = Validaciones.validarDouble();
            Console.WriteLine("Ingrese nombre: ");
            lata2.Volumen = Validaciones.validarDouble();
            return lata2;
        }

        public static Lata recolectarParametros()
        {
            Lata lata3 = new Lata();
            Console.WriteLine("Por favor ingresar codigo");
             lata3.Codigo = Console.ReadLine();
            Console.WriteLine("Por favor ingresar nombre");
            lata3.Nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingresar precio");
             lata3.Precio = Validaciones.validarDouble();
            Console.WriteLine("Por favor ingresar volumen");
            lata3.Volumen = Validaciones.validarDouble();
            Console.WriteLine("Por favor ingresar cantidad");
            lata3.Cantidad = Validaciones.validarInt();
            return lata3;
        }
    }
}
