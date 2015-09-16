using System;

namespace ConsoleApplication1
{
    public class Range : IRange
    {
        public int Lower { get; private set; }
        public int Upper { get; private set; }

        public Range(int lower, int upper)
        {
            if (lower <= upper)
            {
                Lower = lower;
                Upper = upper;
            }
            else
            {
                throw new ArgumentException("The lower value should be less than the upper value.");
            }
        }
    }
}
