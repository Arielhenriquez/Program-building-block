using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_building_block
{
    //override and abstract methods
    public abstract class Automovil
    {
        protected string Propietario { get; set; }
        protected string Modelo { get; set; }
        protected string Color { get; set; }
        protected int Gomas { get; set; }
        protected int Año { get; set; }
        public abstract void Bocina();
        public abstract void Caracteristicas();

    }
    public class Honda : Automovil
    {
        public override void Bocina()
        {
            Console.WriteLine("La bocina suena pi");
        }
        public override void Caracteristicas()
        {
            base.Propietario = "Taljetero";
            base.Modelo = "Civic";
            base.Color = "Negro";
            base.Gomas = 4;
            Console.WriteLine($"El {Propietario} tiene un {Modelo} color {Color} con {Gomas} gomas");
        }
    }
}
