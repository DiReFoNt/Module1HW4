using System;
using System.Linq;

namespace Task1
{
    public class Program
    {
        // method to change numbers in an array and count required letters
        public static int ReplaceNumOnLett(char[] array)
        {
            int count = 0;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += '\u0061';
                switch (array[i])
                {
                    case 'a':
                        array[i] = 'A'; ++count;
                        break;
                    case 'e':
                        array[i] = 'E'; ++count;
                        break;
                    case 'i':
                        array[i] = 'I'; ++count;
                        break;
                    case 'd':
                        array[i] = 'D'; ++count;
                        break;
                    case 'h':
                        array[i] = 'H'; ++count;
                        break;
                    case 'j':
                        array[i] = 'J'; ++count;
                        break;
                    default:
                        break;
                }

                Console.Write(array[i] + " ");
            }

            return count;
        }

        public static void Main(string[] args)
        {
            // Checking input for an error
            Console.WriteLine("Enter the length of the array:");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            int lengthArrayPair = 0;
            int lengthArrayUnpair = 0;
            var rand = new Random();
            if (lengthArray > 0)
            {
                Console.WriteLine("Data accepted");
            }
            else
            {
                throw new Exception("Please check your input");
            }

            // creating an array of the desired length
            var arrayNumber = new int[lengthArray];
            var indexPair = 0;
            var indexUnpair = 0;

            // Filling an array and counting paired and non-paired elements
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                arrayNumber[i] = rand.Next(1, 26);
                Console.Write(arrayNumber[i] + " ");
                if (arrayNumber[i] % 2 == 0)
                {
                    ++lengthArrayPair;
                }
                else
                {
                    ++lengthArrayUnpair;
                }
            }

            // Create pair and unpair array
            var arrayNumberPair = new char[lengthArrayPair];
            var arrayNumberUnpair = new char[lengthArrayUnpair];

            // Converting an array of numbers to an array of characters
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (arrayNumber[i] % 2 == 0)
                {
                    arrayNumberPair[indexPair] = Convert.ToChar(arrayNumber[i]);
                    ++indexPair;
                }

                if (arrayNumber[i] % 2 != 0)
                {
                    arrayNumberUnpair[indexUnpair] = Convert.ToChar(arrayNumber[i]);
                    ++indexUnpair;
                }
            }

            // Calling a method to convert a number character to a unicode letter character and input result
            Console.Write("\nArray paired numbers:");
            int countPair = ReplaceNumOnLett(arrayNumberPair);
            Console.Write("\nArray unpaired numbers:");
            int countUnpair = ReplaceNumOnLett(arrayNumberUnpair);

            // Comparing the number of letters in arrays (a, e, i, d, h, j) and displaying the result
            if (countPair == countUnpair)
            {
                Console.WriteLine($"\nBoth arrays have the same number of letters (a, e, i, d, h, j): {countPair}");
            }

            if (countPair > countUnpair)
            {
                Console.WriteLine($"\nArray with paired numbers has more letters (a, e, i, d, h, j): {countPair}");
            }

            if (countPair < countUnpair)
            {
                Console.WriteLine($"\nArray with unpaired numbers has more letters (a, e, i, d, h, j): {countUnpair}");
            }
        }
    }
}
