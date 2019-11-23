using System;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź dowolną liczbę całkowitą: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            int number;
            if (int.TryParse(input, out number))
            {
                Console.WriteLine("Wprowadzono liczbę całkowitą '" + input + "'");
                Console.WriteLine("Brawo! Trzecie zadanie zrobione :)");
                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            }
            else
            {
                if (input == String.Empty)
                {
                    input = "(pusty string)";
                }
                Console.WriteLine("Wprowadzona wartośc nie jest liczbą całkowitą!" + Environment.NewLine + "Wprowadzono '" + input + "'");
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
