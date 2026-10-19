namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 12;

            switch (edad)
            {
                case < 13:
                    Console.WriteLine("Es un niño");
                    break;

                case < 18:
                    Console.WriteLine("Es un Adolescente");
                    break;

                case < 65:
                    Console.WriteLine(" Es un adulto");
                    break;
                
                default:Console.WriteLine("Es un adulto mayor");
                    break;
            }
        }
    }
}
