using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_advanced
{
    internal static class Helper
    {
        //3
        public static List<int> findEvenNumbers(List<int> arr)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    //    Console.Write(arr[i]);
                    evenNumbers.Add(arr[i]);
                }
            }
            return evenNumbers;
        }
        //2
        public static void ReverseArray<T>(List<T> arr)
        {
            //List<T> reversed = new List<T>();

            for (int i = arr.Count - 1,j=0; i >= 0&&j< arr.Count; i--) 
            {
                T temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
           
        }


        //5
        public static void nonRepeatedCharacter(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                bool isrepeated = true;

                for (int j = 0; j < s.Length; j++)
                {
                    if(i !=j && s[i]== s[j])
                    {
                        isrepeated = false;
                        break;
                    }
                }
                if (isrepeated)
                {
                    Console.WriteLine(s[i]);
                    return;
                }
            }
        }
            
    }
}
