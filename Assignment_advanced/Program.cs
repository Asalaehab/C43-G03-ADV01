using System.Collections;

namespace Assignment_advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Range<char> range = new Range<char>('A', 'E');
            //if (range.IsInRange('B'))
            //    Console.WriteLine($"With in Range");
            //else
            //    Console.WriteLine("Not In Range");
            #endregion


            #region Q2
            //List<int> testList = new List<int> { 1, 2, 3, 4, 5 };
            //Helper.ReverseArray(testList);
            //foreach (var item in testList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q3
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            list2 = Helper.findEvenNumbers(list);
            foreach (int i in list2)
                Console.WriteLine(i);
            #endregion


            #region Q4
            //FixedSizeList<int> numbers = new FixedSizeList<int>(3);
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //Console.WriteLine(numbers.GetM(0)); 
            #endregion


            #region Q5

            //Helper.nonRepeatedCharacter("swiss");
            #endregion

        }
    }
}