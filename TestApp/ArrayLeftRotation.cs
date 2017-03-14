using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
  public class ArrayLeftRotation
    {

        public void leftRotations()
        {
            Console.WriteLine("Enter the length of an array");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of left rotations");
            int k = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 0;
            int firstElement = 0, index = n - 1;
            Console.WriteLine("Enter array values");
            int[] array = new int[n];

            for (i = 0; i<n; i++)
            {
               array[i] =Convert.ToInt32(Console.ReadLine());
            }


           

            for (j = 0; j < k; j++)
            {
                firstElement = array.First();
                for (i = 0; i < index; i++)
                {
                    array[i] = array[i + 1];
                }
                array[index] = firstElement;


            }
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
        }
       
    }
}
