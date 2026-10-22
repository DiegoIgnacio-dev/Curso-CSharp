namespace cicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            for (int i = 0; i < dias.Length; i++) {
                Console.WriteLine(dias[i]);
            }

        }
    }
}
