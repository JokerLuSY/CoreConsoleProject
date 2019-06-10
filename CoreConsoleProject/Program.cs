using System;
using System.Collections.Generic;

namespace CoreConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var newList = new NewList();
            int[] array = { 1,5,4,6,7,9,34};
            var value = MaxSubseqSum1(array,7);
            var value2 = MaxSubseqSum2(array, 7);
            Console.WriteLine(value);
            Console.WriteLine(value2);
            List<int> lists = new List<int>() { 1,2,3,4,5,6};
            
            var findNode = newList.FindNode(3,lists);
            Console.WriteLine("3 is in " + findNode + "position");
            //newList.InsertNode(3,9,ref lists);
            newList.DeleteNode(2, ref lists);
            Console.WriteLine(lists);
        }
        /// <summary>
        /// 给定N个整数的序列{A1,A2......An},
        /// 求函数f(i,j)=max{0,EAk}的最大值
        /// 时间复杂度o(n3)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int MaxSubseqSum1(int[] a, int n)
        {
            int sum = 0;
            int maxSum = 0;
            for (int i = 0; i < n; i++)/* i是子列左端位置*/
            {
                for (int j = i; j < n; j++)/* j是子列右端位置*/
                {
                    sum = 0;
                    for (int k = 0; k<= j; k++)
                    {
                        sum += a[k];
                        if (sum >maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
            return maxSum;
        }
        /// <summary>
        /// o(n2)
        /// </summary>
        /// <param name="b"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int MaxSubseqSum2(int[] b, int n)
        {
            int thisSum = 0;
            int maxSum = 0;
            for (int i = 0; i < n; i++)/* i是子列左端位置*/
            {
                thisSum = 0;
                for (int j = i; j < n; j++)/* j是子列右端位置*/
                {
                    thisSum += b[j];
                }
                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                }
            }
            return maxSum;
        }
    }
}
