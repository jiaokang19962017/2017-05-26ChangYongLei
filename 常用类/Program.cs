using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 常用类
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[] array = new int[7];
            int temp = 0;
            for (int i = 0; i < 7; i++)
            {
                temp = rd.Next(1, 7);
                int j = 0;
                do
                {
                    if (temp == array[i])
                    {
                        i--;
                        break;
                    }
                } while ();

            }


            
        }

    }
}
