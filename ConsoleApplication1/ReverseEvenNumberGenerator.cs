using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// Generates a reverse-ordered, comma delimited
    /// list of even numbers from 100 to 0 inclusive
    /// </summary>
    public class ReverseEvenNumberGenerator : IGenerateOutput
    {
        /// <summary>
        /// Use this class to provide a stream of values to Generate Output
        /// </summary>
        private IEnumerable<int> GetStream()
        {
            for (var i = 0; i <= 100; i++)
            {
                yield return i;
            }
            yield break;
        }

        /// <summary>
        /// Make changes to this method
        /// </summary>
        public string GenerateOutput()
        {
            // use GetStream() for the input range
            return string.Empty;
        }
    }
}
