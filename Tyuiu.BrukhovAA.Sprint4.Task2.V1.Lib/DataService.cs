using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BrukhovAA.Sprint4.Task2.V1.Lib
{
    public class DataService : ISprint4Task2V1
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    res = res * i;
                }
            }
            return res;
        }
    }
}
