namespace Operadores;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("======Operadores Relacionais==== \n"); 

            while (true)
            {
                Console.WriteLine("Insira o primeiro número (x): ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o segundo número(y): ");
                int y = Convert.ToInt32(Console.ReadLine());
                string result;

                //Operador de igualdade (==)

                if (x == y)
                {
                    result = "x é igual a y";
                }

                else
                {
                    result = "x é diferente de y";
                }

                Console.WriteLine("\n Igualdade (==): " + result);

                //Operador de diferença (!=)

                if (x != y)
                {
                    result = "x é diferente de y";
                }
                else
                {
                    result = "x é igual a y";
                }
                Console.WriteLine("\n Diferença (!=): " + result);

                //Operador maior que (>)
                if (x > y)
                {
                    result = "x é maior que y";
                }
                else
                {
                    result = "x não é maior que y";

                }
                Console.WriteLine("\n Maior que (>): " + result);

                //Operador menor que (<)
                if (x < y)
                {
                    result = "x é menor que y";
                }
                else
                {
                    result = "x não é menor que y";
                }
                Console.WriteLine("\n Menor que (<): " + result);

                //Operador maior ou igual (>=)
                if (x >= y)
                {
                    result = "x é maior ou igual a y";
                }
                else
                {
                    result = "x não é maior ou igual a y";
                }
                Console.WriteLine("\n Maior ou igual (>=): " + result);

                //Operador menor ou igual (<=)
                if (x <= y)
                {
                    result = "x é menor ou igual a y";
                }
                else
                {
                    result = "x não é menor ou igual a y";
                }

                Console.WriteLine("\n Menor ou igual (<=): " + result);
                Console.WriteLine("-------------------------------- \n");
            }
        }
    }   
}
