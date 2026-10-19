namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //las funciones nos permiten reutilizar codigo de manera que podemos invocar una funcion cuando lo 
            //necesitemos ,podemos pasarle parametros si es necesario

            
            //llamamos a la funcion suma ,pasando dos parametros, de igual manera podemos crear parametros por default 
            //en caso de faltar un parametro

            Suma(77, 98);

            NombreCompleto("Diego", "Avila");

            Mensaje();


            int Respuesta = ResultadoMultiplicacion(7, 9);
            Console.WriteLine("El resultado de la operacion realizada por la funcion es:" +Respuesta);



        }

        static void Suma(int a = 0,int b= 0)
        {
            int resultado = a + b;
            Console.WriteLine(resultado);
        }

        static void NombreCompleto (string nombre,string apellido)
        {
            Console.WriteLine(nombre + " " + apellido);
        }

        static void Mensaje()
        {
            Console.WriteLine("Hola que tal");
        }

        static int ResultadoMultiplicacion(int a = 0,int b = 0)
        {
            return a * b;
        }
    }
}
