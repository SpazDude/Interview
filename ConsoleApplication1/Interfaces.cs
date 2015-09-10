namespace ConsoleApplication1
{
    public interface IClass
    {
        string GenerateOutput();
    }

    public interface IRange
    {
        int Lower { get; }
        int Upper { get; }
    }
}
