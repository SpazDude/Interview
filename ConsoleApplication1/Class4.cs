using System.Text;

namespace ConsoleApplication1
{
    /// <summary>
    /// fizz-buzz generator
    /// </summary>
    public class Class4 : IClass
    {
        private readonly IRange _range;

        public Class4(IRange range)
        {
            _range = range;
        }

        public string GenerateOutput()
        {
            var builder = new StringBuilder();
            for (var i = _range.Lower; i < _range.Upper; i++)
            {
                if (i % 6 == 0) builder.Append("fizzbuzz ");
                else if (i % 3 == 0) builder.Append("buzz ");
                else if (i % 2 == 0) builder.Append("fizz ");
                else builder.AppendFormat("{0} ", i);
            }
            return builder.ToString();
        }
    }
}
