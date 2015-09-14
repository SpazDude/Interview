namespace ConsoleApplication1
{
    public interface IIntExtensions
    {
        bool IsEven(int value);
        bool IsOdd(int value);
    }

    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this int value)
        {
            return value % 2 == 1;
        }
    }

    #region Alternate Implementation
    public class IntExtensions2 : IIntExtensions
    {
        public bool IsEven(int value)
        {
            return (value & 0x1) == 0;
        }

        public bool IsOdd(int value)
        {
            return (value & 0x1) == 1;
        }
    }
    #endregion
}
