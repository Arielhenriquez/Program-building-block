using System;

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
            //Members
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
        internal class Program
        {
           
            static void Main(string[] args)
            {
            int[] lista = { 0, 2, 4, 8 };
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            const double piValue = 3.14;
                var toyota = new Carro()
                {
                    Año = 2000,
                    Marca = "Toyota"
                };
                toyota.Acelerar();

            Statements oStatements = new Statements();
            oStatements.Comprobacion();
            oStatements.Tabla();
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

