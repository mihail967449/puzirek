using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 сортировка ОМ по адресу 
            int[] array = {12,-76,-6,-34, 1};
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for(int j = i+1; j<nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            int p = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = p;
            //        }
            //    }
            //}
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
    }
}
