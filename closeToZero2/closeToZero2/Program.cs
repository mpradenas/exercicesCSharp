using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace closeToZero2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion="";
            
            int target = 0;
            int[] ints = new int[4];
            do
            {
                opcion = "";
                int maxNum = int.MaxValue;
                int minNum = int.MinValue;
                int inputValue = 0;

                for (int i = 0; i < ints.Length; i++)
                {
                    Console.WriteLine("Insert an integer n°{0}",(i+1));
                    inputValue = int.Parse(Console.ReadLine());
                    ints[i] = inputValue;
                }

                foreach (int data in ints)
                {
                    if (data <= target)
                    {

                        if (data >= minNum)
                        {
                            minNum = data;
                        }
                    }
                    else if (data >= target)
                    {
                        if (data <= maxNum)
                        {
                            maxNum = data;
                        }
                    }
                   
                }
                if (minNum == int.MinValue) minNum = Math.Abs(minNum - 1);

                if ((maxNum - target) < (Math.Abs(minNum) - target))
                {
                    Console.WriteLine("the closer to zero is {0}", maxNum);
                }
                else
                {
                    Console.WriteLine("The closer to zero is {0}", minNum);
                }
                Console.WriteLine("try again?S/N");
                opcion = Console.ReadLine();
                while (opcion != "s" && opcion != "S" && opcion != "n" && opcion != "N")
                {
                    Console.WriteLine("insert a valid choice?");
                    opcion = Console.ReadLine();
                }

            } while (opcion.ToLower() == "s");
            Console.ReadLine();
        }
    }
}
