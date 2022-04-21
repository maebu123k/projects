using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3by3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3X3 ARRAY VARIABLE
            int[,] array = new int[3, 3];

            //STORES USER INPUT
            String input;

            //STORES THE SUM OF ROWS AND COLUMNS
            int sum_row1 = 0, sum_row2 = 0, sum_row3 = 0, sum_col1 = 0, sum_col2 = 0, sum_col3 = 0;

            //PROMPTS AND READS USER INPUT PER ROW
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number in {0} row: ", i+1);
                input = Console.ReadLine();

                //GETS EACH ELEMENT OF ARRAY IN THE ROW BY USING STRING MANIPULATION
                //AND PARSING
                array[i, 0] = Convert.ToInt32(input.Substring(0, input.IndexOf(" ")));
                array[i, 1] = Convert.ToInt32(input.Substring(input.IndexOf(" ")+1, input.LastIndexOf(" ")-1));
                array[i, 2] = Convert.ToInt32(input.Substring(input.LastIndexOf(" ")+1));
            }
            
            //COMPUTES FOR THE SUM OR ROWS AND COLUMNS
            sum_row1 = array[0, 0] + array[0, 1] + array[0, 2];
            sum_row2 = array[1, 0] + array[1, 1] + array[1, 2];
            sum_row3 = array[2, 0] + array[2, 1] + array[2, 2];
            sum_col1 = array[0, 0] + array[1, 0] + array[2, 0];
            sum_col2 = array[0, 1] + array[1, 1] + array[2, 1];
            sum_col3 = array[0, 2] + array[1, 2] + array[2, 2];

            //PRINTS OUT THE ARRAY WITH THE SUM OF COLUMNS AND ROWS
            Console.WriteLine("\nArrays");
            Console.WriteLine("======================\n");
            Console.WriteLine("{0}\t{1}\t{2}\t=\t{3}", array[0, 0], array[0, 1], array[0, 2], sum_row1);
            Console.WriteLine("{0}\t{1}\t{2}\t=\t{3}", array[1, 0], array[1, 1], array[1, 2], sum_row2);
            Console.WriteLine("{0}\t{1}\t{2}\t=\t{3}\n", array[2, 0], array[2, 1], array[2, 2], sum_row3);
            Console.WriteLine("=========\n");
            Console.WriteLine("{0}\t{1}\t{2}",sum_col1,sum_col2,sum_col3);
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
