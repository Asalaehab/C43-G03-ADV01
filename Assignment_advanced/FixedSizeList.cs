using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_advanced
{
    internal class FixedSizeList<T>
    {
        public int Capacity { get; set; }
        public List<T> List { get; set; }
        private int counter;

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            List = new List<T>();
            counter = 0;
        }
        public void Add(T item)
        {
            if (counter < Capacity)
            {
                List.Add(item);
                counter++;
            }
            else
            {
                Console.WriteLine("Capacity Full");
            }
        }
        public T GetM(int index)
        {
            if (index < 0 || index >= List.Count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }
            return List[index];
        }
    }
}
