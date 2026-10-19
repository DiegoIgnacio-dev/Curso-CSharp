namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables de tipo string
            //Son como Cajas a las cuales les asignamos un nombre y un contenido

            string caja = "objeto";
            string animal = "Gato";


            Console.WriteLine("Un "+animal+ " no es un "+ caja);

            //variables numericas
            int numero = 10;
            int numeroDos = 20;

            int resultadoSuma = numero + numeroDos;

            Console.WriteLine("El resultado de la suma es: "+resultadoSuma);

            //double: para calculos cientificos generales s
            double pi = 3.1416;
            double peso = 65.8;

            //decimal para calculos de dinero o bancarios
            decimal impuesto =19.99m;

            //caracter guarda un caracter por variable
            char opcion = 'A';

        }
    }
}
