using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_advanced
{
    internal class Range<T> where T: IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T mn, T mx)
        {
            Min = mn;
            Max = mx;
        }
        public bool IsInRange(T value)
        {
            if(value.CompareTo(Min) > 0)
            {
                if(value.CompareTo(Max)<0)
                    return true;
            }
            return false;
        }
        //public T GetLength()
        //{
        //   //return
        //}
        public override string ToString()
        {
            return $"min : {Min}, max : {Max}";
        }
    }
}
