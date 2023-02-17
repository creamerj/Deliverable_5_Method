/*
 * Name: Jessica Creamer
 * Date: 2/15/2023
 * Description: Program that collects an integer from a user and uses two methods to display the elements
 * */

namespace Deliverable_5_Method
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                while (input < 5 || input > 15)
                {
                    Console.WriteLine("Enter an integer between 5 and 15: ");
                    input = int.Parse(Console.ReadLine());
                    if (input < 5 || input > 15)
                       {
                        Console.WriteLine("Sorry that's not right, please enter an integer number between 5 and 15.");
                       }
                }
                int[] sampleArray = random_array(input);
                Console.WriteLine("The elements of the arrays are: ");

                foreach (int element in sampleArray)
                {
                   Console.Write(element + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(sampleArray));
            }
            catch
            {
                Console.WriteLine("Please enter an integer number between 5 and 15.");
            }
        }
    }
}