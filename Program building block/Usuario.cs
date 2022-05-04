using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_building_block
{
    //Virtual methods
    public class Usuario
    {
        protected string Nombre { get; set; }
        public virtual void Registro()
        {
            this.Nombre = "Jose";
            Console.WriteLine($"El usuario {Nombre} se ha registrado");
        }

        public class Usuario2 : Usuario
        {
            public override void Registro()
            {
                base.Nombre = "Juan";
                Console.WriteLine($"{Nombre} Te haz registrado satisfactoriamente! ");
            }
        }

    }
}
