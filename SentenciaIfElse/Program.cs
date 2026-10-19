namespace SentenciaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            La sentecia if else trabaja de la mano con los valores booleanos True | False
            
            En español seria :
            Si la condicion A se cumple entonces has esto

            Si (mi caja tiene mas de un objeto)
            entonces es una caja llena
             */

            int huevos = 0;

            if (huevos > 0)
            {
                Console.WriteLine("la bandeja tiene huevos");
            }


            /*Otra variante es cuando incluimos la sentencia else
             * y esto daria otra continuidad a la afirmacion
             * 
             *  Si (mi caja tiene mas de un objeto)
                entonces es una caja llena,
                Si no Entoces (es una caja vacia) 
             */

            if(huevos  > 0)
            {
                Console.WriteLine("La bandeja tiene huevos");
            }
            else
            { 
                Console.WriteLine("La bandeja no tiene huevos"); 
            }

        }
    }
}
