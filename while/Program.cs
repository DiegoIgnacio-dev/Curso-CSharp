namespace Whileite;

internal class Program
{
    static void Main(string[] args)
    {
        int i = 0;

        while (i < 10)
        {
            Console.WriteLine("Iteracion de i :"+i++);
        }


        int j = 0;

        while (j < 1000000)
        {
            if(j > 19)
            {
                break;
            }
            Console.WriteLine("Iteracion de J:"+j);
            j++;
        }


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


        int a = 0;
        while (a < dias.Length) {
           
            Console.WriteLine(dias[a]);
            a++;
        }
    }
}
