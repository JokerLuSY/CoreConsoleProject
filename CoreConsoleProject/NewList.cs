using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsoleProject
{
    /// <summary>
    /// 线性表存储
    /// </summary>
    public class NewList
    {
        public int FindNode(int num, List<int> newList)
        {
            for (int i = 0; i < newList.Count; i++)
            {
                if (num == newList[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public void InsertNode(int num , int element,ref List<int> newList)
        {
            if (num >newList.Count+1)
            {
                Console.WriteLine("not right");
                return;
            }
            for (int i = newList.Count; i > num; i--)
            {
                newList[i + 1] = newList[i];
            }
            newList[num] = element;
        }
        public void DeleteNode(int num ,ref List<int> newList)
        {
            if (newList.Count +1 < num)
            {
                Console.WriteLine("wrong");
            }
            for (int i = 0; i < newList.Count; i++)
            {

            }
        }
    }
}
