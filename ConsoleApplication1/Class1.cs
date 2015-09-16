using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    /// <summary>
    /// generate a comma delimited list of numbers with a provided range
    /// </summary>
    public class Class1: IOutputGenerator
    {
        private int _upper;
        private int _lower;

        public void SetRange(int lower, int upper)
        {
            if (lower >= upper) throw new ArgumentOutOfRangeException("lower", lower, "The lower value should be less than the upper value.");
            _lower = lower;
            _upper = upper;
        }

        public string GenerateOutput()
        {
            var results = new List<int>();
            for (var i = _lower; i <= _upper; i++)
            {
                results.Add(i);
            }
            return string.Join(", ", results);
        }
    }
}
