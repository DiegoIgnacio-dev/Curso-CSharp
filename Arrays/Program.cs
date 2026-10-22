namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //un arreglo es una un tipo de variable que puede guardar una coleccion de variables

            string[] autos = new string[7];

            autos[0] = "Toyota";
            autos[1] = "Nissan";
            autos[2] = "Suzuki";
            autos[3] = "Dodge";
            autos[4] = "Citroen";
            autos[5] = "Peugeot";
            autos[6] = "Lada";

            Console.WriteLine(autos[1]);


            string[] dias = new string[7]
            {
                "Lunes",
                "Martes",
                "Miercoles",
                "Jueves",
                "Viernes",
                "Sabado",
                "Domingo"
            };

            Console.WriteLine(dias[0]);

            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine(dias[i]);
            }
        }
    }
}
