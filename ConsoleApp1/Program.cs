using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //ES UN PEQUEÑO CODIGO PARA PRACTICAR 
            //SI HAY ALGUN ERROR POR FAVOR ME AYUDAN 
            //AOENAS ESTOY INICIANDO EN EL MUNDO DE LA PROGRAMACION EN ESTE LENGUAJE

            String nombre1, nombre2, nombre3, nombre4,nombre5;
            Console.WriteLine("!BIENVENIDO¡");
            Console.WriteLine("");
            Console.WriteLine("DIGITE SU NOMBRE...");
            nombre1 = Convert.ToString(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("DIGITE SU NOMBRE...");
            nombre2 = Convert.ToString(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("DIGITE SU NOMBRE...");
            nombre3 = Convert.ToString(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("DIGITE SU NOMBRE...");
            nombre4 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("DIGITE SU NOMBRE...");
            nombre5 = Convert.ToString(Console.ReadLine());
            Console.WriteLine();


            persona[] personas = new persona[5];
            personas[0] = new alumno(nombre1);
            personas[1] = new empleado(nombre2);
            personas[2] = new contador(nombre3);
            personas[3] = new profesor(nombre4);
            personas[4] = new abogado(nombre5);


            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].saludar());
            }


            Console.ReadKey();
        }

        public abstract class persona
        {
            public string Nombre { set; get; }
            public abstract string saludar();
        }
        public class alumno : persona
        {
            public alumno(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string saludar()
            {

                string saludo = "HOLA MI NOMBRE ES " + this.Nombre + " Y SOY APRENDIZ SENA";
                return saludo;
            }
        }
        public class empleado : persona
        {
            public empleado(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string saludar()
            {

                string saludo = "HOLA MI NOMBRE ES " + this.Nombre + " Y SOY  EMPLEADO(A) PUBLICA";
                return saludo;

            }
        }
        public class profesor : persona
        {
            public profesor(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string saludar()
            {
                string saludo = "HOLA MI NOMBRE ES " + this.Nombre + " Y SOY MAESTRO(a) ";
                return saludo;
            }

        }
        public class contador : persona
        {
            public contador(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string saludar()
            {
                string saludo = "HOLA MI NOMBRE ES " + this.Nombre + " Y SOY CONTADOR";
                return saludo;
            }

        }
        public class abogado : persona
        {
            public abogado(string nombre)
            {
                this.Nombre = nombre;
            }
            public override string saludar()
            {
                string saludo = "HOLA MI NOMBRE ES " + this.Nombre + " Y SOY ABOGADO";
                return saludo;
            }

        }
    }
}

