using System;

namespace Utils
{
    public class Range<T> where T: IComparable
    {
        public int RangeId { get; set; }
        public T Min { get; set; }
        public T Max { get; set; }
    }
}
