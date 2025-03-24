using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    internal class ArrayT2 : IMath
    {
        private int[] data;

        public ArrayT2(int[] inputData)
        {
            data = inputData;
        }

        public int Max()
        {
            int max = data[0];
            foreach (int num in data)
            {
                if (num > max)
                {
                    max = num; 
                }
                
            }
            return max;
        }

        public int Min()
        {
            int min = data[0];
            foreach (int num in data)
            {
                if (num < min)
                {
                    min = num;
                }
               
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int num in data)
            {
                sum += num;
            }
            return (float)sum / data.Length;
        }

        public bool Search(int value)
        {
            foreach (int num in data)
            {
                if (num == value)
                    return true;
            }
            return false;
        }
    }
}
