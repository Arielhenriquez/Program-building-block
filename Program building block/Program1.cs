using System;
using static Program_building_block.Usuario;

namespace Program_building_block
{
    //Accesibility
    class Animal
    {
        private string dog = "Perro", cat = "Gato";
        public void Correr()
        {
            Console.Write("El" + dog + "Corre");
        }
    }

        public class Carro
        {
            public string color;
           
            public Carro()
            {
                color = "Rojo";
            }
            public int Año { get; set; }
            public string Marca { get; set; }
            public void Acelerar()
            {
                Console.WriteLine($"El carro {Marca} de color {color} del año {Año} acelera");
            }
        }
        internal class Program1
        {
        static void Main(string[] args)
            {
            string continuar;
            do
            {
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1.Throw, 2.Polimorfismo, 3.Statements. 4.Members, Otra opcion clase static");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        //throw
                        int[] lista = { 0, 2, 4, 8 };
                        try
                        {
                            Console.WriteLine(lista[4]);
                        }
                        catch (Exception)
                        {

                            throw new Exception("Indice no existe");
                        }
                        finally
                        {
                            foreach (int i in lista)
                            {

                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case "2":
                        //Polimorfismo
                        var jose = new Usuario();
                        jose.Registro();
                        var juan = new Usuario2();
                        juan.Registro();
                        break;

                    case "3":
                        Console.WriteLine("Introduzca su edad: ");
                        var oStatements = new Statements();
                        oStatements.Comprobacion();
                        oStatements.Tabla();
                        break;

                    case "4":
                        //Members
                        const double piValue = 3.14;
                        var toyota = new Carro()
                        {
                            Año = 2000,
                            Marca = "Toyota"
                        };
                        toyota.Acelerar();
                        break;

                    default:
                        var operacion = ClaseStatic.Resta(20,5);
                        Console.WriteLine(operacion);
                        break;

                }
                Console.WriteLine("Desea ver otra operacion? (si/no?)");
                continuar = Console.ReadLine();
            } while (continuar == "si");
            
        }

        //Parameters
        static void Suma(int num1, int num2)
        {
            int result = num1 + num2;
        }
        //Method overloading
        static void Suma(double num1, double num2)
        {
            double result = num1 + num2;
        }
    }
}

